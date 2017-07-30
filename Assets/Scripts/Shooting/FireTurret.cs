using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTurret : MonoBehaviour {
    public Transform bulletPosition;

    public GameObject projectile;
    public float fireDelta = 0.5F;

    private float nextFire = 0.5F;
    private GameObject newProjectile;
    private float myTime = 0.0F;

    private bool isPowered;

    void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire && isPowered)
        {
            nextFire = myTime + fireDelta;
            newProjectile = Instantiate(projectile, bulletPosition.position, bulletPosition.rotation) as GameObject;

            // create code here that animates the newProjectile

            nextFire = nextFire - myTime;
            myTime = 0.0F;
        }
    }

    public void powerSystem(bool power)
    {
        isPowered = power;
    }
}
