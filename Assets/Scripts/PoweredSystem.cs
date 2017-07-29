using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredSystem : MonoBehaviour {


    private bool isPowered = false;

    public bool IsPowered
    {
        get { return isPowered;  }
    }

    public float drainCost = 1.0f;
    private Battery battery;

    private void Start()
    {
        battery = Battery.Instance;
    }

    private void Update()
    {
        if (isPowered)
        {
            battery.drainPower(drainCost * Time.deltaTime);
        }
        
    }

    public void setPowered(bool power)
    {
        isPowered = power;
        //fire event
        if (power)
        Debug.Log("power");
        gameObject.SendMessage("powerSystem", isPowered, SendMessageOptions.DontRequireReceiver);
    }
}
