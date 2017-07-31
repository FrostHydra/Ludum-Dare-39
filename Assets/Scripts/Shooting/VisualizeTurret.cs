using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PoweredSystem))]
public class VisualizeTurret : MonoBehaviour {

    public SpriteRenderer turret;
    public Color activeColor;
    public Color inactiveColor;

    public void powerSystem(bool power)
    {
        if (power)
        {
            turret.color = activeColor;
        } else
        {
            turret.color = inactiveColor;

        }
    }
}
