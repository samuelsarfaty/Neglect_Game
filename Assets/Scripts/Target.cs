﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	private Renderer myRenderer;

	void Awake(){
		myRenderer = GetComponent<Renderer> ();
	}
		
}
