using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SystemButton
{
    public string name;
    //public bool isPowered;
    public PoweredSystem shipSystem;

}

public class DrawButtons : MonoBehaviour {

    public GUISkin buttonLayout;
    //public string[] buttonName;
    //public bool[] buttonOn;
    public SystemButton[] systemButtons;


	// Use this for initialization
	void Start () {
        for (int i = 0; i < systemButtons.Length; i++)
        {
            systemButtons[i].shipSystem.setPowered(false);
        }
	}

    private void OnGUI()
    {
        for (int i = 0; i < systemButtons.Length; i++)
        {
            int buttonStyle = 1;
            if (systemButtons[i].shipSystem.IsPowered)
            {
                buttonStyle = 0;
            }
            if (GUI.Button(new Rect(
                Screen.width / 20, (Screen.height / (systemButtons.Length + 2)) * (i + 1),
                Screen.width / 6, Screen.height / (systemButtons.Length + 2)), systemButtons[i].name, buttonLayout.customStyles[buttonStyle]))
            {
                systemButtons[i].shipSystem.setPowered( !systemButtons[i].shipSystem.IsPowered );
                if (systemButtons[i].shipSystem.IsPowered)
                {
                    
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
