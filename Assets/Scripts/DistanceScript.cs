﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour {

    public float speed;
    public float distance;
    private float startDistance;
    public bool isMoving;

    public GUISkin buttonLayout;
    public Texture arrowTexture;
    public int arrowSize;

    void Start()
    {
        startDistance = distance;
    }

	// Update is called once per frame
	void Update () {
        if (isMoving && distance > 0)
        {
            distance -= (speed * Time.deltaTime);
        }

        if(distance <= 0)
        {
            distance = 0;
            Victory();
        }
	}

    public void Victory()
    {
        //Do Something
    }

    public void StopMovement()
    {
        isMoving = false;
    }

    public void StartMovement()
    {
        isMoving = true;
    }

    public void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 10 * 2, Screen.height / 20 * 18, Screen.width / 10 * 6, Screen.height / 20), "", buttonLayout.customStyles[2]);
        GUI.DrawTexture(new Rect(Screen.width / 10 * 2 + (Screen.width / 10 * 6) * (1 - distance/startDistance) - arrowSize/2, Screen.height / 20 * 18, arrowSize, arrowSize), arrowTexture);
    }
}
