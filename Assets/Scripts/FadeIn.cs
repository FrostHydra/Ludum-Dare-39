using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {

    public float startingDistance = 1000000;
    
    public Color colorB;
    public Color colorE;

    private DistanceScript distance;
    private float lerpValue = 0;


    private void Awake()
    {
        distance = FindObjectOfType<DistanceScript>();

        colorB = GetComponent<SpriteRenderer>().color;
        colorE = new Color(colorB.r, colorB.g, colorB.b, 0f);
    }

	void Update () {

        if (distance.distance < startingDistance)
        {
            lerpValue = 1 - (distance.distance / startingDistance);
        }
        
        GetComponent<SpriteRenderer>().color = Color.Lerp(colorE, colorB, lerpValue);
        
	}
}
