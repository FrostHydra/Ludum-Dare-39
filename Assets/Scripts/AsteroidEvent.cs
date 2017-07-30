using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "AsteroidEvent", menuName = "Asteroids/Event", order = 1)]
public class AsteroidEvent : ScriptableObject {

    public float triggerDistance;
    public int asteroidAmount;
    public float spawnDelay;
}
