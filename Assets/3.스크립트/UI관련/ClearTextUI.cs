using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTextUI : MonoBehaviour
{
    // 8 12 18
    public int A;

    void Start()
    {
        if (PlayerPrefs.GetInt("chapter") != A)
        {
            gameObject.SetActive(false);
        }
    }
}
