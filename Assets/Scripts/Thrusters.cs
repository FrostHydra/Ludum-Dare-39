using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PoweredSystem))]
public class Thrusters : MonoBehaviour {

    //public float thrusterScalar = 2;
    public float accelConstant =     10;
    public float accelScale = 1.01f;
    public float deacceleration = 50000;
    private float tempDeacceleration;

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
            if(ShipStats.Instance.velocity < 10000)
            {
                ShipStats.Instance.velocity += accelConstant * 10;
                tempDeacceleration = 0;
            }
            else
            {
                ShipStats.Instance.velocity += accelConstant;
            }
            ShipStats.Instance.velocity *= accelScale;
        } else
        {
            if (tempDeacceleration < deacceleration)
            {
                tempDeacceleration += deacceleration/100;
            }
            else
            {
                tempDeacceleration = deacceleration;
            }
            ShipStats.Instance.velocity -= tempDeacceleration * Time.deltaTime;
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
