using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			transform.Rotate (new Vector3 (transform.rotation.x, transform.rotation.y + 90, transform.rotation.z));
		} else if (Input.GetMouseButtonDown (1)) {
			Destroy (gameObject);
		}
	}
}
