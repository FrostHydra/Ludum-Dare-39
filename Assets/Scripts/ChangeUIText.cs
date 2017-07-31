using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeUIText : MonoBehaviour {

    private Text text;
    public bool victoryScreen;


    private void Start()
    {
        if (victoryScreen)
        {
            text = this.gameObject.GetComponent<Text>();
            text.text += GameObject.Find("Sound_Manager").GetComponent<GetStats>().GetEnergy();
            
        }
        else
        {
            text = this.gameObject.GetComponent<Text>();
            text.text += GameObject.Find("Sound_Manager").GetComponent<GetStats>().GetDistance();
        }
        
    }
}
