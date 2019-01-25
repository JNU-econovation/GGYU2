using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public Transform WhiteHole;
    public Animator BA;
    public Animator WA;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Player")
        {
            col.transform.position = WhiteHole.position;
            BA.SetTrigger("isAct");
            WA.SetTrigger("isAct");
        }
    }
}
