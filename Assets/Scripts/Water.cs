using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

	void OnParticleCollision (GameObject other){
		if (other.name == "Cube") {
			//print ("Collided");
		}
	}
}
