using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceRotate : MonoBehaviour {
    public float rotSpeed = 0.03f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, rotSpeed);
	}
}
