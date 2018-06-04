using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			transform.Rotate (new Vector3 (0, 90, 0));
		} else if (Input.GetMouseButtonDown (1)) {
			Destroy (gameObject);
		}
	}
}
