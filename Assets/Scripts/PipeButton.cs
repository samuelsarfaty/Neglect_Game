using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeButton : MonoBehaviour {

	public GameObject pipePrefab;
	[HideInInspector]
	public bool isSelected;

	private GameObject selectionFrame;
	private PipeButton[] buttons;

	void Awake(){
		selectionFrame = GetComponentInChildren<SelectionFrame> ().gameObject;
		buttons = GameObject.FindObjectsOfType<PipeButton> ();
		isSelected = false;

	}

	// Use this for initialization
	void Start () {
		DeSelect ();

	}

	void Update(){
		if (isSelected) {
			Vector3 temp = Input.mousePosition;
		}
	}
	
	public void Select(){
		foreach (PipeButton button in buttons) {
			button.DeSelect ();
		}

		selectionFrame.SetActive (true);
		isSelected = true;
	}

	public void DeSelect(){
		selectionFrame.gameObject.SetActive (false);
		isSelected = false;
	}
}
