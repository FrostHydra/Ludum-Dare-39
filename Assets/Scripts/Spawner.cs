using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] asteroidPrefab;
    public float asteroidSpeed = 5.0f;

    public List<AsteroidEvent> events;


    void Update()
    {
        // Asteroid event
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AsteroidEvent(5, 5);
        }
    }

    public void AsteroidEvent(int spawnNumber, float totalDuration)
    {
        StartCoroutine(SpawnDelay(totalDuration/spawnNumber, spawnNumber));
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

    IEnumerator SpawnDelay(float delay, int times)
    {
        Spawn();
        yield return new WaitForSeconds(delay);
        if (times > 0)
        {
            StartCoroutine(SpawnDelay(delay,times-1));
        }
    }
}
