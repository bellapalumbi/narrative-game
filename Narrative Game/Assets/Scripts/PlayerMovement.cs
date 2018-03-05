﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

		transform.Translate(0,y,0);
		transform.Translate(x,0,0);
	}
}
