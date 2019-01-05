using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbySwipe : MonoBehaviour {
    private Vector2 startTP, endTP;
    public GameObject chapter;

    int swit = 1;

    void Start ()
    {
		if(PlayerPrefs.GetInt("Stage",1)==1)
        {
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTP = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTP = Input.GetTouch(0).position;
            if (endTP.x - startTP.x > 100f && swit > 1)
            {
                StartCoroutine(leftRot());
            }
            if (startTP.x - endTP.x > 100f && swit < 4)
            {
                transform.localScale = new Vector3(0, 0, 0);
                StartCoroutine(rightRot());
            }
        }
    }
    IEnumerator leftRot()
    {
        int countTime = 0;
        while (countTime < 10)
        {
            chapter.GetComponent<RectTransform>().Rotate(0, 0, -4.5f);
            yield return new WaitForSeconds(0.01f);
            countTime++;
        }
        swit--;
        yield return null;
    }
    IEnumerator rightRot()
    {
        int countTime = 0;
        while (countTime < 10)
        {
            chapter.GetComponent<RectTransform>().Rotate(0, 0, 4.5f);
            yield return new WaitForSeconds(0.01f);
            countTime++;
        }
        swit++;
        yield return null;
    }

}
