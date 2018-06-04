using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeButton : MonoBehaviour {

	private GameObject selectionFrame;

	void Awake(){
		selectionFrame = GetComponentInChildren<SelectionFrame> ().gameObject;
	}

	// Use this for initialization
	void Start () {
		selectionFrame.gameObject.SetActive (false);
	}
	
	public void Select(){
		selectionFrame.gameObject.SetActive (true);
	}
}
