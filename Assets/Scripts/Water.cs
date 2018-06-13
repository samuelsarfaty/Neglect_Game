using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour {

	[HideInInspector]
	public bool hasSplashed; //Used to know if to play splash SFX on child gameobject

	private AudioSource splash;

	void Awake(){
		splash = transform.GetChild (0).GetComponent<AudioSource> ();
		hasSplashed = false;

	}
		
	void OnParticleCollision (GameObject other){
		if (hasSplashed == false && (other.GetComponent<FloorPiece>() || other.GetComponent<Pipe>())) {
			hasSplashed = true;
			splash.Play ();
		}

		if (other.GetComponent<Mill> ()) {
			Mill myMill = other.GetComponent<Mill> ();
			if (!myMill.isRotating) {
				myMill.ActivateMill();

			}

		}

	}

}
