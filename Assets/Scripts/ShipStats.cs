using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : GenericSingletonClass<ShipStats>
{

    public int health = 10;


    public float velocity = 0;
    public float maximumVelocity = 1000000;


    private void LateUpdate()
    {
        if (velocity > maximumVelocity) velocity = maximumVelocity;
        if (velocity < 0) velocity = 0;
    }

    public void GetDamage(int damage)
    {
        velocity /= 2;
        health -= damage;
    }

    public void Heal(int heal)
    {
        health += heal;
    }

    public float GetVelocity()
    {
        return velocity;
    }
}