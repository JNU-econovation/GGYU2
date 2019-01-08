using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
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
        if(rgdy.velocity.x >14f || rgdy.velocity.x < -14f || rgdy.velocity.y > 14f|| rgdy.velocity.y < -14f)
        {
            Destroy(gameObject);
        }
        else
        {
            rgdy.velocity = new Vector2(0f,0f);
            PS.coll();
        }
    }
}
