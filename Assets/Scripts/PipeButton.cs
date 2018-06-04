using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeButton : MonoBehaviour {

	private GameObject selectionFrame;
	private PipeButton[] buttons;

	void Awake(){
		selectionFrame = GetComponentInChildren<SelectionFrame> ().gameObject;
		buttons = GameObject.FindObjectsOfType<PipeButton> ();
	}

	// Use this for initialization
	void Start () {
		DeSelect ();
	}
	
	public void Select(){
		foreach (PipeButton button in buttons) {
			button.DeSelect ();
		}

		selectionFrame.SetActive (true);
	}

	public void DeSelect(){
		selectionFrame.gameObject.SetActive (false);
	}
}
