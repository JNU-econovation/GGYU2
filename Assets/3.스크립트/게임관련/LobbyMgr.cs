using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMgr : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1080, 1920, true);
    }
    public void exit()
    {
        Application.Quit();
    }
}