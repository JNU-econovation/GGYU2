using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Last : MonoBehaviour
{
    private Vector2 startTP, endTP;
    int Laika = 0;
    public GameObject LK;
    public GameObject lat;
    Animator am;
    // Start is called before the first frame update
    void Start()
    {
        am = LK.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTP = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTP = Input.GetTouch(0).position;
            if (endTP.x - startTP.x > 100f)
            {
                Laika++;
            }
            if (startTP.x - endTP.x > 100f)
            {
                Laika++;
            }

            if(Laika==20)
            {
                am.enabled = true;
                lat.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}

