using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

	private Water water;

	void Awake(){
		water = GameObject.FindObjectOfType<Water> ();
	}

	// Use this for initialization
	void Start () {
		water.gameObject.SetActive (false);
	}
	
	public void StartWater(){
		water.gameObject.SetActive (true);
	}
}
