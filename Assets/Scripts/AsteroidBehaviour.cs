using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

    public float speed;
    public float rotationspeed;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);
        transform.position = position;
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * rotationspeed));
        

        Vector2 end = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if(transform.position.y < end.y )
        {
            Destroy(gameObject);
            print("it's destroyed");
        }

        
	}
}
