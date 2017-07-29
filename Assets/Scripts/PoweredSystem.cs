using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredSystem : MonoBehaviour {

    public bool isPowered = false;
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

        //
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TogglePower();
        }
    }

    public void TogglePower()
    {
        isPowered = !isPowered;
    }
}
