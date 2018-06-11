using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

	private Water water;
	private bool isWaterActive;
	private Text buttonText;


	void Awake(){
		water = GameObject.FindObjectOfType<Water> ();
		isWaterActive = false;
		buttonText = GetComponentInChildren<Text> ();
	}

	// Use this for initialization
	void Start () {
		//water.gameObject.SetActive (false);
		StopWater();
	}

	public void Activate(){
		if (!isWaterActive) {
			StartWater ();
		} else {
			StopWater ();
		}
	}
	
	void StartWater(){
		water.gameObject.SetActive (true);
		isWaterActive = true;
		buttonText.text = "Stop";
	}

	void StopWater(){
		water.gameObject.SetActive (false);
		isWaterActive = false;
		buttonText.text = "Begin!";
	}


}
