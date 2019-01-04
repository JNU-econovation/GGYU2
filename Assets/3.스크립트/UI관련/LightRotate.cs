using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotate : MonoBehaviour {

    GameObject Player;
    PlayerRotation PR;
    RectTransform RT;
    private void Start()
    {
        Player = GameObject.Find("Player");
        PR = Player.GetComponent<PlayerRotation>();
        RT = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (PR.dir == 0) //하
        {
            RT.localPosition = new Vector3(0f, -388f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 180f);
        }
        else if (PR.dir == 1) //좌
        {
            RT.localPosition = new Vector3(-405f, 13f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 90f);
        }
        else if (PR.dir == 2) //상
        {
            RT.localPosition = new Vector3(0f, 418f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (PR.dir == 3) //우
        {
            RT.localPosition = new Vector3(405f, 13f, 0);
            transform.rotation = Quaternion.Euler(0, 0, -90f);
        }
    }
}
