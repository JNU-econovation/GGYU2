using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMgr : MonoBehaviour
{
    
    //public int stage = 0;
    void Start()
    {
        //PlayerPrefs.SetInt("Stage", stage);
        Screen.SetResolution(1080, 1920, true);
    }
    public void exit()
    {
        Application.Quit();
        Debug.Log("EXIT");
    }
}