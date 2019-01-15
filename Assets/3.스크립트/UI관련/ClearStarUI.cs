using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStarUI : MonoBehaviour
{
    // chapter미만시 꺼지기
    // 해당챕터일때 빛나기
    // Start is called before the first frame update
    Animator ani;
    void Start()
    {
        if(int.Parse(transform.name)>PlayerPrefs.GetInt("chapter"))
        {
            gameObject.SetActive(false);
        }
        else if(int.Parse(transform.name)==PlayerPrefs.GetInt("chapter"))
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
