using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour {

    public GameObject g1;
    public GameObject g2;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.name.Equals("Player"))
        {
            g1.SetActive(true);
            g2.SetActive(false);
        }
    }
}
