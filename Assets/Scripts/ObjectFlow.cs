using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFlow : MonoBehaviour {

	public GameObject particle;
	public bool isActive;

	void Awake(){
		isActive = false;
	}

	void Start(){
		particle.gameObject.SetActive (false);
	}

	public void Action(){
		if (!isActive) {
			particle.gameObject.SetActive (true);
			isActive = true;
		} else {
			particle.gameObject.SetActive (false);
			isActive = false;
		}
	}
}
