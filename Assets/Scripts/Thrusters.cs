using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PoweredSystem))]
public class Thrusters : MonoBehaviour {

    public float thrusterVolocity = 5;
    PoweredSystem system;
    private void Start()
    {
        system = GetComponent<PoweredSystem>();
    }

    public void powerSystem(bool isPowered)
    {
        if (isPowered)
        {
            ShipStats.Instance.velocity += thrusterVolocity;
        } else
        {
            ShipStats.Instance.resetVelocity();
        }
    }
}
