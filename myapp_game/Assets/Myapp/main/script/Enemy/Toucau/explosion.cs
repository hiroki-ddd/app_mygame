﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 2);//2秒後にDestroy
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
