using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PoweredSystem))]
public class Thrusters : MonoBehaviour {

    public float thrusterScalar = 2;
    PoweredSystem system;
    private void Start()
    {
        system = GetComponent<PoweredSystem>();
    }

    public void powerSystem(bool isPowered)
    {
        if (isPowered)
        {
            ShipStats.Instance.velocity *= thrusterScalar;
        } else
        {
            ShipStats.Instance.resetVelocity();
        }
    }
}
