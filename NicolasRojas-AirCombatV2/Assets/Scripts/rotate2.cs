﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate(0.0f,0.0f,0.0f);
		this.transform.Rotate(0.0f,10.0f,0.0f);
	}
}
