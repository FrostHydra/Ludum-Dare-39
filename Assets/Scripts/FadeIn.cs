using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {


    public float fadeSpeed;
    public Color colorB;
    public Color colorE;


    private void Awake()
    {
        colorB = GetComponent<SpriteRenderer>().color;
        colorE = new Color(colorB.r, colorB.g, colorB.b, 0f);
    }

	void Update () {
        fadeSpeed += Time.deltaTime;
        GetComponent<SpriteRenderer>().color = Color.Lerp(colorE, colorB, fadeSpeed * 0.1f);
        if(fadeSpeed == 30)
        {
            fadeSpeed = 30;
        }
	}
}
