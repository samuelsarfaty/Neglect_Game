using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Target : MonoBehaviour {

	private Renderer myRenderer;
	private GameManager gm;

	void Awake(){
		myRenderer = GetComponent<Renderer> ();
		gm = GameObject.FindObjectOfType<GameManager> ();
	}

	public void Acquire(){
		GetComponent<CapsuleCollider> ().isTrigger = true;
		myRenderer.material.color = Color.blue;
		gm.IncreaseScore ();
	}
		
}
