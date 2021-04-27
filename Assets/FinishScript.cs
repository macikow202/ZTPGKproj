using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    private bool GUIEnabledWin = false;
    private GUIStyle guiStyleWin = new GUIStyle();

    void OnGUI()
    {
        guiStyleWin.fontSize = 50;
        guiStyleWin.normal.textColor = Color.green;

        if (GUIEnabledWin)
        {
            GUI.Label(new Rect((Screen.width / 2) - 100, (Screen.height / 2) - 15 , 100, 30), "YOU WIN", guiStyleWin);
            if (GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 2 ) + 50 , 100, 30), "Exit Game"))
            {
                Application.Quit();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Player")
        {
            Time.timeScale = 0;
            this.GUIEnabledWin = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
