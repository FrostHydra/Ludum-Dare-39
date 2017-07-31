using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : GenericSingletonClass<Battery> {


    public float startingPower = 100;
    [HideInInspector]
    public float powerRemaining;

    public bool isGameOver;

    private void Start()
    {
        powerRemaining = startingPower;
    }

    public void drainPower(float amount)
    {
        powerRemaining -= amount;
        checkPower();
    }

    private void checkPower()
    {
        if(powerRemaining < 0)
        {
            powerRemaining = 0;
            // gameover

            if (!isGameOver)
            {
                isGameOver = true;
                FindObjectOfType<SceneSwitch>().LoadScene("Defeat");

            }
        }
    }
}
