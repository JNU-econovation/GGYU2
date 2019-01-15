using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearStarUI2 : MonoBehaviour
{

    public Image IMG;
    float total;
    public float plus;
    public int starLoad;
    void Start()
    {
        IMG = GetComponent<Image>();
        total = 100;
        plus = 0.5f;

        if (starLoad > PlayerPrefs.GetInt("chapter"))
        {
            gameObject.SetActive(false);
        }
        else if (starLoad == PlayerPrefs.GetInt("chapter"))
        {
            IMG.fillAmount = 0;
        }
    }
    void Update()
    {
        if (starLoad == PlayerPrefs.GetInt("chapter"))
        {
            IMG.fillAmount += plus / total;
        }
    }
}
