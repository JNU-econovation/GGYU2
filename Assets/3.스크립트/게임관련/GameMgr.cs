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
    public GameObject Fade;
    Animator ani;

    public GameObject SpaceShip;
    Vector3 originPos;

    void Start()
    {
        if (PlayerPrefs.GetInt("Stage") < Stage)
        {
            PlayerPrefs.SetInt("Stage", Stage);
        }
        Fade = GameObject.Find("Fade");
        space = GameObject.Find("Space");
        Aud = GameObject.Find("Audio");
        Eaud = GameObject.Find("End Audio");
        ani = space.GetComponent<Animator>();

        Fade.SetActive(false);

        SpaceShip = GameObject.Find("SpaceShip");
        originPos = SpaceShip.transform.localPosition;
    }

    void Update()
    {
        // 스테이지 클리어
        if (StarNum == StageStarNum)
        {
            StarNum = 0;
            space.GetComponent<SpaceRotate>().enabled=false;
            Fade.SetActive(true);
            StartCoroutine(Shake(10f, 1.3f));
            // 스테이지 넘어가기
            Destroy(Aud);
            ani.enabled = true;
            StartCoroutine("delay");

        }
    }

    IEnumerator delay()
    {
        Eaud.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2f);
        GetComponent<NextScene>().nScene();
    }
    public IEnumerator Shake(float _amount, float _duration)
    {
        float timer = 0;
        while (timer <= _duration)
        {
            SpaceShip.transform.localPosition = (Vector3)Random.insideUnitCircle * _amount + originPos;

            timer += Time.deltaTime;
            yield return null;
        }
        SpaceShip.transform.localPosition = originPos;
    }
}
