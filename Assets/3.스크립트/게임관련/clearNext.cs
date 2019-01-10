using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearNext : MonoBehaviour
{
    public GameObject Guide;
    public GameObject chapter;

    void Start()
    {
        StartCoroutine(CN());
        if(PlayerPrefs.GetInt("chapter",1).Equals(1))
        {
            chapter.transform.localRotation = Quaternion.Euler(0, 0, -45f);
        }
        else if (PlayerPrefs.GetInt("chapter", 1).Equals(8))

        {
            chapter.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (PlayerPrefs.GetInt("chapter", 1).Equals(12))
        {
            chapter.transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
    }

    IEnumerator CN()
    {
        yield return new WaitForSeconds(3f);
        Guide.SetActive(true);
    }
}
