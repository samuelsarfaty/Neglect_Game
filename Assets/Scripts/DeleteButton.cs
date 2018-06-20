using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour {

	public void DeletePaths(){
		GameObject[] pathPieces = GameObject.FindGameObjectsWithTag ("WaterPath");

		foreach (GameObject path in pathPieces) {
			Destroy (path.gameObject);
		}
	}
}
