using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSystem : MonoBehaviour {

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
}
