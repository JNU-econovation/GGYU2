using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLine : MonoBehaviour {

    public int lineNum;

	// Use this for initialization
	void Start () {
	    if(lineNum > PlayerPrefs.GetInt("Stage",1))
        {
            gameObject.SetActive(false);
        }
	}
}
