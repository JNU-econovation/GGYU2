using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{

    // 목표점수 StarNum에 현재 StageStarNum이 도달시 다음 스테이지로 넘어가는 스크립트
    public int Stage;
    public int StageStarNum;
    public static int StarNum = 0;
    public GameObject space, Aud, Eaud;
    Animator ani;

    void Start()
    {
        if (PlayerPrefs.GetInt("Stage") < Stage)
        {
            PlayerPrefs.SetInt("Stage", Stage);
        }

        space = GameObject.Find("Space");
        Aud = GameObject.Find("Audio");
        Eaud = GameObject.Find("End Audio");
        ani = space.GetComponent<Animator>();
    }

    void Update()
    {
        // 스테이지 클리어
        if (StarNum == StageStarNum)
        {
            StarNum = 0;

            // 스테이지 넘어가기
            Destroy(Aud);
            ani.enabled = true;
            StartCoroutine("delay");

        }
    }

    IEnumerator delay()
    {
        Eaud.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1.2f);
        GetComponent<NextScene>().nScene();
    }
}
