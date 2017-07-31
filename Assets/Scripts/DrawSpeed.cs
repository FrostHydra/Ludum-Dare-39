using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSpeed : MonoBehaviour {

    public GUISkin buttonLayout;
    private float speed;

    void Update()
    {
        speed = ShipStats.Instance.GetVelocity() / 500;
    }

    public void OnGUI()
    {
        GUI.TextField(new Rect(Screen.width / 25, Screen.height / 50, Screen.width / 5, Screen.height / 10), speed.ToString("0") + " distance / s", buttonLayout.customStyles[3]);
    }
}
