using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarName : MonoBehaviour {

    public int CompleteNum;
    public Text tx;

	void Start ()
    {
        tx = GetComponent<Text>();
		if(CompleteNum>=PlayerPrefs.GetInt("Stage",1))
        {
            tx.text = "< unknown >";
            tx.color = new Color(1, 0, 0);
        }
	}

}
