using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStats : MonoBehaviour {

    public GameObject batteryObj;
    Battery battery;

    public GameObject distanceObj;
    DistanceScript distanceScript;
    string distance;

    private float energyLeft;
    private float maxEnergy;

    public string percentagePower;
	
	// Update is called once per frame
	void Update () {
        if(batteryObj != null)
        {
            energyLeft = battery.GetPower();
            percentagePower = ((energyLeft / maxEnergy) * 100).ToString("0.0") + "% battery left";
        }
        else
        {
            if (GameObject.Find("Battery"))
            {
                batteryObj = GameObject.Find("Battery");
                battery = batteryObj.GetComponent<Battery>();
                maxEnergy = battery.GetMaxPower();
            }
        }

        if(distanceObj != null)
        {
            distance = (distanceScript.GetMaxDistance() - distanceScript.GetDistanceLeft()).ToString("0") + " distance reached";
        }
        else
        {
            if (GameObject.Find("ButtonManager"))
            {
                distanceObj = GameObject.Find("ButtonManager");
                distanceScript = distanceObj.GetComponent<DistanceScript>();

            }
        }
    }

    public string GetDistance()
    {
        return distance;
    }

    public string GetEnergy()
    {
        return percentagePower;
    }
}
