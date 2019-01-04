using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectBlinkUI : MonoBehaviour
{
    Image img;
    bool isHide = true;
    public float alpha = 0.3f;
    public float max = 1f;

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

            if (color.a < alpha)
            {
                color.a = alpha;
                isHide = false;
            }
            img.color = color;
        }
        else
        {
            Color color = img.color;
            color.a = color.a + Time.deltaTime;

            if (color.a > max)
            {
                color.a = max;
                isHide = true;
            }
            img.color = color;
        }
        //Debug.Log(isHide);
    }

}