using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour {

	void OnParticleCollision (GameObject other){
		if (other.GetComponent<FloorPiece>()) {
			print ("water fell");
			print (other.name);
		}

		if (other.GetComponent<Mill> ()) {
			Mill myMill = other.GetComponent<Mill> ();
			if (!myMill.isRotating) {
				myMill.isRotating = true;
				myMill.GetComponent<BoxCollider> ().isTrigger = true;

			}

		}

	}

}
