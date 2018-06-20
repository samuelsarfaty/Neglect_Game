using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Mill[] mills;
	public GameObject colorPanel;

	private Water water;
	private StartButton startButton;
	private bool isWaterActive;

	void Awake(){
		water = GameObject.FindObjectOfType<Water> ();
		startButton = GameObject.FindObjectOfType<StartButton> ();
		isWaterActive = false;
	}

	void Start(){
		StopAction ();
	}

	public void Activate(){
		if (!isWaterActive) {
			StartAction ();
			startButton.SwitchText ();
		} else {
			StopAction ();
			startButton.SwitchText ();
			foreach (Mill mill in mills) {
				mill.ResetMill ();
			}
		}
	}

	public void StartAction(){
		water.gameObject.SetActive (true);
		colorPanel.gameObject.SetActive (true);
		isWaterActive = true;
	}

	public void StopAction(){
		water.gameObject.SetActive (false);
		colorPanel.gameObject.SetActive (false);
		isWaterActive = false;
		water.hasSplashed = false;
	}
}
