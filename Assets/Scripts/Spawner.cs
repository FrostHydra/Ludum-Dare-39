using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] spawnLocations;
    public GameObject[] spawnPrefab;
    public GameObject[] spawnClone;
    public float spawntime;


	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        SpawnEnemy();
	}


    public void SpawnEnemy()
    {

        spawnClone[0] = Instantiate(spawnPrefab[Random.Range(0, 4)], spawnLocations[Random.Range(0,4)].transform.position, Quaternion.identity) as GameObject;

        

    }
}


        //int spawnType = Random.Range(0, 3);
        //int spawnDirection = Random.Range(0, 5);

        //Vector2 spawnPosition = new Vector2(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y);
        //print(spawnPosition);
        //Instantiate(asteroids[spawnType], spawnPosition, Quaternion.identity

        //GameObject newAsteroid = (gameObject)Instantiate(asteroids[randomNumber], spawnLocation);

        //asteroids = asteroids[Random.Range(0, asteroids.Length)];

