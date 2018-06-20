using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {
	
	public string startText;
	public string stopText;

	private Text buttonText;
	private bool isTextGo;


	void Awake(){
		buttonText = GetComponentInChildren<Text> ();
		isTextGo = true;
	}

	// Use this for initialization
	void Start () {
		buttonText.text = startText;
	}

	public void SwitchText(){
		if (isTextGo) {
			buttonText.text = stopText;
			isTextGo = false;
		} else {
			buttonText.text = startText;
			isTextGo = true;
		}
	}
		
}
