using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour {

    private float speed;
    public float distance;
    private float startDistance;
    public bool isMoving;

    public GUISkin buttonLayout;
    public Texture arrowTexture;
    public int arrowSizeX;
    public int arrowSizeY;

    void Start()
    {
        startDistance = distance;
    }

	// Update is called once per frame
	void Update () {

        speed = ShipStats.Instance.velocity;
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
        FindObjectOfType<SceneSwitch>().LoadScene("Victory");
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
        GUI.DrawTexture(new Rect(Screen.width / 10 * 2 + (Screen.width / 10 * 6) * (1 - distance/startDistance) - arrowSizeX/2, Screen.height / 20 * 18, arrowSizeX, arrowSizeY), arrowTexture);
        GUI.TextField(new Rect(Screen.width / 10 * 4, Screen.height / 20 * 18, Screen.width / 5, Screen.height / 10), (distance/500).ToString("0") + " distance", buttonLayout.customStyles[3]);
    }

    public float GetDistanceLeft()
    {
        return distance / 500;
    }

    public float GetMaxDistance()
    {
        return startDistance / 500;
    }
}
