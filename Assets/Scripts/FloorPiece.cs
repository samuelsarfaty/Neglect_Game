using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPiece : MonoBehaviour {

	public Material[] mats;

	private Renderer myMat;
	private Vector3 pipeSpawnPos;
	private PipeButton[] buttons;
	private GameObject myPipe;

	void Awake(){
		myMat = GetComponent<Renderer> ();
		pipeSpawnPos = new Vector3 (transform.position.x, 2.5f, transform.position.z);
		buttons = GameObject.FindObjectsOfType<PipeButton> ();
	}

	void OnMouseOver(){
		myMat.material = mats [1];

	}

	void OnMouseExit(){
		myMat.material = mats [0];
	}



	void OnMouseDown(){
		if (!myPipe) {
			foreach (PipeButton button in buttons) {
				if (button.isSelected) {
					myPipe = Instantiate (button.pipePrefab, pipeSpawnPos, Quaternion.identity);
					myPipe.transform.parent = this.transform;
				
				}
			}
		}
	}
		
}
