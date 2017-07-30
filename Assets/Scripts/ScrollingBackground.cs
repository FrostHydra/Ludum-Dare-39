using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float maxScrollSpeed = 0.4F;
    private float scalar;
    float offset = 0;
    Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        scalar = maxScrollSpeed / ShipStats.Instance.maximumVelocity;
    }
    void Update()
    {
        offset += Time.deltaTime * scalar * ShipStats.Instance.velocity;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
