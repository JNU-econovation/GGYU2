using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dark : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DarkUp());
    }

    IEnumerator DarkUp()
    {
        for (int i = 0; i < 40; i++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Translate(0, -70f, 0);
        }
        yield return null;
        gameObject.SetActive(false);
    }
}
