using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPiece : MonoBehaviour {

	public Material[] mats;

	private Renderer myMat;
	private Vector3 pipeSpawnPos;
	private PipeButton[] buttons;
	private bool hasPipe;

	void Awake(){
		myMat = GetComponent<Renderer> ();
		pipeSpawnPos = new Vector3 (transform.position.x, 2.5f, transform.position.z);
		buttons = GameObject.FindObjectsOfType<PipeButton> ();
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
			foreach (PipeButton button in buttons) {
				if (button.isSelected) {
					Instantiate (button.pipePrefab, pipeSpawnPos, Quaternion.identity);
				}
			}
		}

		hasPipe = true;
	}

}
