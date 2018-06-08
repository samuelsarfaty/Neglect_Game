using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Target : MonoBehaviour {

	private Renderer myRenderer;

	void Awake(){
		myRenderer = GetComponent<Renderer> ();
	}

	public void Acquire(){
		GetComponent<CapsuleCollider> ().isTrigger = true;
		myRenderer.material.color = Color.blue;
	}
		
}
