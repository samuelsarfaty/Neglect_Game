using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPiece : MonoBehaviour {

	public Material[] mats;

	private Renderer myMat;

	void Awake(){
		myMat = GetComponent<Renderer> ();
	}

	void OnMouseOver(){
		myMat.material = mats [1];

	}

	void OnMouseExit(){
		myMat.material = mats [0];
	}

}
