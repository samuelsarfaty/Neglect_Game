using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour {

	void OnParticleCollision (GameObject other){
		if (other.GetComponent<FloorPiece>()) {
			print ("water fell");
			print (other.name);
			//SceneManager.LoadScene (0);
		}

		if (other.GetComponent<Target> ()) {
			other.GetComponent<Target> ().Acquire ();

		}

	}

}
