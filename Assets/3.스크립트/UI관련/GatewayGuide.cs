using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatewayGuide : MonoBehaviour
{
    public GameObject Guide1;
    public GameObject Guide2;
    PlayerSort PS;
    int num;
    // Update is called once per frame
    void Start()
    {
        num = 0;
        PS = GetComponent<PlayerSort>();
    }

    void Update()
    {
        if(!PS.gate)
        {
            Guide1.SetActive(false);
        }
        if(num>5)
        {
            Guide2.SetActive(true);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.tag=="Wall")
        {
            if(transform.position.y>3f&& transform.position.x< 3f)
            {
                num++;
            }
        }
    }
}
