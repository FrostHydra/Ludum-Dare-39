using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] asteroidPrefab;
    public float asteroidSpeed = 5.0f;

    public List<AsteroidEvent> events;
    private DistanceScript distance;

    private void Awake()
    {
        distance = FindObjectOfType<DistanceScript>();
    }

    void Update()
    {

        for (int i = 0; i < events.Count; i++)
        {
            if (distance.distance < events[i].triggerDistance)
            {
                StartCoroutine(SpawnEvent(events[i]));
                events.Remove(events[i]);
            }
        }
    }

    IEnumerator SpawnEvent(AsteroidEvent wave)
    {
        for (int i = 0; i < wave.asteroidAmount; i++)
        {
            Spawn();

            yield return new WaitForSeconds(wave.spawnDelay); 
        }
    }

    public void Spawn()
    {
        int spawnDirection = Random.Range(0, 3);
        Vector3 spawnLocation = new Vector3(10, 0, 0);
        switch (spawnDirection)
        {
            case 0:
                spawnLocation = new Vector3(0.0f, Random.Range(0.0f, 1.0f), -Camera.main.transform.position.z);
                break;
            case 1:
                spawnLocation = new Vector3(1.0f, Random.Range(0.0f, 1.0f), -Camera.main.transform.position.z);
                break;
            case 2:
                spawnLocation = new Vector3(Random.Range(0.0f, 1.0f), 1.0f, -Camera.main.transform.position.z);
                break;
            case 3:
                spawnLocation = new Vector3(Random.Range(0.0f, 1.0f), 0.0f, -Camera.main.transform.position.z);
                break;
        }
        GameObject asteroid = Instantiate(asteroidPrefab[Random.Range(0, asteroidPrefab.Length)], Camera.main.ViewportToWorldPoint(spawnLocation), this.transform.rotation);

        Vector2 velocity = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, -Camera.main.transform.position.z)) - asteroid.transform.position;
        velocity = velocity.normalized * asteroidSpeed;

        asteroid.GetComponent<Rigidbody2D>().velocity = velocity;


    }
}
