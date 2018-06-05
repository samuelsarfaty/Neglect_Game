using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text scoreText;

	private Target[] targets;
	private int scoreCount;

	void Awake(){
		targets = GameObject.FindObjectsOfType<Target> ();
		scoreCount = 0;
	}

	void Start(){
		scoreText.text = scoreCount + " / " + targets.Length;
	}

	public void IncreaseScore(){
		scoreCount++;
		scoreText.text = scoreCount + " / " + targets.Length;
	}

	void Update(){
		if (scoreCount >= targets.Length) {
			scoreText.color = Color.yellow;
		}
	}



}
