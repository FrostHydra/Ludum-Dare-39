using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PoweredSystem))]
public class Thrusters : MonoBehaviour {

    //public float thrusterScalar = 2;
    public float accelConstant =     10000;
    public float accelScale;
    public float deacceleration = 50000;

    public GameObject shipFire;

    PoweredSystem system;
    private void Start()
    {
        system = GetComponent<PoweredSystem>();

    }

    private void Update()
    {

        if (system.IsPowered)
        {
            ShipStats.Instance.velocity += accelConstant;
            ShipStats.Instance.velocity *= accelScale;
        } else
        {
            ShipStats.Instance.velocity -= deacceleration * Time.deltaTime;
        }
    }

    public void powerSystem(bool isPowered)
    {
        shipFire.SetActive(isPowered);
        //if (isPowered)
        //{
        //    ShipStats.Instance.velocity *= thrusterScalar;
        //} else
        //{
        //    ShipStats.Instance.resetVelocity();
        //}
    }
}
