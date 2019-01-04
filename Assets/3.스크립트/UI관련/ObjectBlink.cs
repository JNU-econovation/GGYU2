using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBlink : MonoBehaviour
{
    SpriteRenderer SR;
    bool isHide = true;
    public float alpha = 0.3f;
    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isHide)
        {
            Color color = SR.color;
            color.a = color.a - Time.deltaTime;

            if (color.a < alpha)
            {
                color.a = alpha;
                isHide = false;
            }
            SR.color = color;
        }
        else
        {
            Color color = SR.color;
            color.a = color.a + Time.deltaTime;

            if (color.a > 1)
            {
                color.a = 1.0f;
                isHide = true;
            }
            SR.color = color;
        }
        //Debug.Log(isHide);
    }

}