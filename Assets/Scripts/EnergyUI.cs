using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class EnergyUI : MonoBehaviour {

    public Image fill;

    Slider powerSlider;
    Battery battery;
    private float maxPower;

	// Use this for initialization
	void Start () {
        powerSlider = GetComponent<Slider>();
        battery = Battery.Instance;
        maxPower = battery.startingPower;

    }
	
	// Update is called once per frame
	void Update () {
        powerSlider.value = battery.powerRemaining / maxPower;

        fill.color = Color.Lerp(Color.white, Color.red, 1 - powerSlider.value);
	}
}
