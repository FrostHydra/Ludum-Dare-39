using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour {

    private float posX;
    public float distance;
    private float sinNr = 0;

    void Start()
    {
        posX = this.gameObject.transform.position.x;
    }

    void Update() {
        sinNr += (ShipStats.Instance.velocity / 500000) * Time.deltaTime;
        float newPosX = posX + (distance * Mathf.Sin(sinNr));
        this.transform.position = new Vector3(newPosX, this.transform.position.y, this.transform.position.z);
       
	}
}
