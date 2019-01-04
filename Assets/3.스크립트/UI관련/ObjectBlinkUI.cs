using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectBlinkUI : MonoBehaviour
{
    Image img;
    bool isHide = true;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (isHide)
        {
            Color color = img.color;
            color.a = color.a - Time.deltaTime;

            if (color.a < 0.3f)
            {
                color.a = 0.3f;
                isHide = false;
            }
            img.color = color;
        }
        else
        {
            Color color = img.color;
            color.a = color.a + Time.deltaTime;

            if (color.a > 1)
            {
                color.a = 1.0f;
                isHide = true;
            }
            img.color = color;
        }
        //Debug.Log(isHide);
    }

}