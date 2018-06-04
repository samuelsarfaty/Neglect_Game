using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPiece : MonoBehaviour {

	public Material[] mats;
	public GameObject[] pipes;

	private Renderer myMat;
	private Vector3 pipeSpawnPos;
	private bool hasPipe;

	void Awake(){
		myMat = GetComponent<Renderer> ();
		pipeSpawnPos = new Vector3 (transform.position.x, 2.5f, transform.position.z);
		hasPipe = false;
	}

	void OnMouseOver(){
		myMat.material = mats [1];

	}

	void OnMouseExit(){
		myMat.material = mats [0];
	}

	void OnMouseDown(){
		if (!hasPipe) {
			Instantiate (pipes [1], pipeSpawnPos, Quaternion.identity);
			hasPipe = true;
		} else {
			print ("pipe already here");
		}
	}

}
