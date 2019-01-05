using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSwitch : MonoBehaviour {

	void Start () {

        if (int.Parse(transform.name)==PlayerPrefs.GetInt("Stage",1))
        {
            //반짝거리게
            GetComponent<ObjectBlinkUI>().enabled = true;
        }
        else if(int.Parse(transform.name) > PlayerPrefs.GetInt("Stage",1))
        {
            gameObject.SetActive(false);
        }
	}
}
