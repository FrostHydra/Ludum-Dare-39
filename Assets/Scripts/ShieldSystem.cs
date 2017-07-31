using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSystem : MonoBehaviour
{
    public float drainOnHit = 10;
    private Renderer rend;
    private Collider2D coll;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        coll = GetComponent<Collider2D>();

        rend.enabled = false;
        coll.enabled = false;

    }

    public void powerSystem(bool isPowered)
    {
        rend.enabled = isPowered;
        coll.enabled = isPowered;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Hazard"))
        {
            Battery.Instance.drainPower(drainOnHit);
        }
    }
}
