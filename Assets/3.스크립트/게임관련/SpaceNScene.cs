using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpaceNScene : MonoBehaviour
{

    public GameObject L1;
    public GameObject L2;

    public void LobbyTouch()
    {
        GetComponent<Animator>().enabled = true;
        L1.GetComponent<Animator>().enabled = true;
        L2.GetComponent<Animator>().enabled = true;
    }
}
