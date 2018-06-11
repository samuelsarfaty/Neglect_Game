using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mill : MonoBehaviour {

	public float rotationSpeed;
	public bool isRotating;

	private BoxCollider myCollider;

	void Awake(){
		isRotating = false;
		myCollider = GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isRotating) {
			transform.Rotate (Vector3.left, rotationSpeed * Time.deltaTime);
		}
			
	}

	public void ResetMill(){
		isRotating = false;
		transform.rotation = Quaternion.Euler (Vector3.zero);
		myCollider.isTrigger = false;

	}

	void MoveMill(){
		transform.Rotate (Vector3.left, rotationSpeed * Time.deltaTime);
		GetComponent<BoxCollider> ().isTrigger = true;
	}

}
