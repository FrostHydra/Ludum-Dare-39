using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : GenericSingletonClass<ShipStats>
{

    public int health = 10;
    public float velocity = 5;
    [SerializeField]
    private float baseVelocity = 5;

    private void Start()
    {
        resetVelocity();
    }

    public void resetVelocity()
    {
        velocity = baseVelocity;
    }

    public void GetDamage(int damage)
    {
        health -= damage;
    }

    public void Heal(int heal)
    {
        health += heal;
    }
}