using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSpeed : MonoBehaviour {

    public GUISkin buttonLayout;
    
    public void OnGUI()
    {
        GUI.TextField(new Rect(Screen.width / 50, Screen.height / 50, Screen.width / 5, Screen.height / 10), (ShipStats.Instance.GetVelocity()).ToString("0") + " km/h", buttonLayout.customStyles[3]);
    }
}
