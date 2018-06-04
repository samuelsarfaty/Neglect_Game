using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	void OnMouseDown(){
		transform.Rotate (new Vector3 (transform.rotation.x, transform.rotation.y + 90f, transform.rotation.z));
	}
}
