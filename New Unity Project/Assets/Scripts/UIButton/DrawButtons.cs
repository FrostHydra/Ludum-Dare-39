using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawButtons : MonoBehaviour {

    public GUISkin buttonLayout;
    public string[] buttonName;
    public bool[] buttonOn;


	// Use this for initialization
	void Start () {
        buttonOn = new bool[buttonName.Length];
        for(int i = 0; i < buttonOn.Length; i++)
        {
            buttonOn[i] = false;
        }
	}

    private void OnGUI()
    {
        for (int i = 0; i < buttonName.Length; i++)
        {
            int buttonStyle = 1;
            if (buttonOn[i])
            {
                buttonStyle = 0;
            }
            if (GUI.Button(new Rect(Screen.width / 20, (Screen.height / (buttonName.Length + 2)) * (i + 1), Screen.width / 6, Screen.height / (buttonName.Length + 2)), buttonName[i], buttonLayout.customStyles[buttonStyle]))
            {
                buttonOn[i] = !buttonOn[i];
                if (buttonOn[i])
                {
                    
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
