using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {

    private float posX;
    public float speed;
    public float distance;
    private float sinNr = 0;

    void Start()
    {
        posX = this.gameObject.transform.position.y;
    }

    void Update () {
        float newPosX = posX + (distance * Mathf.Sin(speed * Time.time));
        this.transform.position = new Vector3(newPosX, this.transform.position.y, this.transform.position.z);
	}
}
