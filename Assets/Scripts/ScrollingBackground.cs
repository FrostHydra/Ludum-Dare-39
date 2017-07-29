using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float scrollSpeedScalar = 0.05F;
    float offset = 0;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        offset += Time.deltaTime * scrollSpeedScalar * ShipStats.Instance.velocity;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
