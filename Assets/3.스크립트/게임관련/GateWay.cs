using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateWay : MonoBehaviour
{
    public GameObject TP;

    GameObject Player;
    Rigidbody2D rgdy;
    PlayerSort PS;

    void Start()
    {
        Player = GameObject.Find("Player");
        rgdy = Player.GetComponent<Rigidbody2D>();
        PS = Player.GetComponent<PlayerSort>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (PS.gate)
        {
            PS.isMove = false;
            PS.gate = false;
            StartCoroutine(Rot1());
            Player.transform.position = transform.position;
            PS.coll();
            rgdy.velocity = new Vector3(0, 0, 0);
        }
        else if(!PS.gate)
        {
            PS.isMove = false;
            PS.gate = true;
            StartCoroutine(Rot2());
            Player.transform.position = transform.position;
            PS.coll();
            rgdy.velocity = new Vector3(0, 0, 0);
        }
    }
    IEnumerator Rot1()
    {
        yield return null;
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.01f);
            TP.transform.Rotate(0, 4.5f, 0);
        }
        rgdy.isKinematic = false;
        rgdy.gravityScale = 1f;
    }
    IEnumerator Rot2()
    {
        yield return null;
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.01f);
            TP.transform.Rotate(0, -4.5f, 0);
        }
        rgdy.isKinematic = false;
        rgdy.gravityScale = 1f;
    }
}
