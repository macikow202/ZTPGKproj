using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesTouch : MonoBehaviour
{
    private bool GUIEnabledLose = false;
    private GUIStyle guiStyleLose = new GUIStyle();

    void OnGUI()
    {
        guiStyleLose.fontSize = 50;
        guiStyleLose.normal.textColor = Color.red;

        if (GUIEnabledLose)
        {
            GUI.Label(new Rect((Screen.width / 2) - 125, (Screen.height / 2) - 15, 100, 30), "YOU LOSE", guiStyleLose);
            if (GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 2) + 50, 100, 30), "Exit Game"))
            {
                Application.Quit();
            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Player")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0;
            this.GUIEnabledLose = true;
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
