using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour {

	void OnParticleCollision (GameObject other){
		if (other.GetComponent<FloorPiece>()) {
			SceneManager.LoadScene (0);
		}
	}
}
