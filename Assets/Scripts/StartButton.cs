using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

	public Mill myMill;
	public string startText;
	public string stopText;

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
		buttonText.text = startText;
		StopWater();
	}

	public void Activate(){
		if (!isWaterActive) {
			StartWater ();
		} else {
			StopWater ();
			if (myMill) {
				myMill.ResetMill ();
			}
		}
	}
	
	void StartWater(){
		water.gameObject.SetActive (true);
		isWaterActive = true;
		buttonText.text = stopText;

	}

	void StopWater(){
		water.gameObject.SetActive (false);
		isWaterActive = false;
		buttonText.text = startText;
		water.hasSplashed = false;
	}


}
