using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {

    public float maxSpeed = 0.1f;
    private float speed;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        speed = (ShipStats.Instance.velocity / ShipStats.Instance.maximumVelocity) * maxSpeed;

        Vector2 position = transform.position;
        position = new Vector2(position.x, position.y - speed *Time.deltaTime);
        transform.position = position;

        Vector2 end = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if (transform.position.y < end.y)
        {
            Destroy(gameObject);
            print("it's destroyed");
        }
    }

}
