using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTurret : MonoBehaviour {

    [Range(-10, 10)]
    public float depth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion targetRot;

        Vector3 v3 = Input.mousePosition;
        v3.z = depth;
        v3 = Camera.main.ScreenToWorldPoint(v3) - transform.position;
        v3.Normalize();

        float rot_z = Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f,rot_z - 90);
	}
}
