using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotatator : MonoBehaviour {

    float rotation;
    float speed;

    void Start()
    {
        rotation = Random.Range(0, 360);
        speed = Random.Range(25.0f, 45.0f);
        if (Random.Range(0, 2) == 0)
        {
            speed *= -1;
        }
    }

    // Update is called once per frame
    void Update () {
        rotation += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation);
    }
}
