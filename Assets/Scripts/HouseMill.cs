using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseMill : MonoBehaviour {

	private MeshRenderer myRenderer;
	private GameObject smoke;

	public Material[] mats;
	public bool isActivated;


	void Awake(){
		myRenderer = GetComponent<MeshRenderer> ();
		isActivated = false;
		smoke = transform.GetChild (0).gameObject; 
	}

	void Start(){
		smoke.gameObject.SetActive (false);
	}

	public void Activate(){
		myRenderer.materials[2].color = Color.yellow;
		smoke.gameObject.SetActive (true);

	}

	public void DeActivate(){
		myRenderer.materials [2].color = Color.black;
		smoke.gameObject.SetActive (false);
	}

}
