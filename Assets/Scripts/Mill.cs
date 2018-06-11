using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mill : MonoBehaviour {

	public float rotationSpeed;
	public bool isRotating;

	void Awake(){
		isRotating = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isRotating) {
			MoveMill ();
		}
	}

	void MoveMill(){
		transform.Rotate (Vector3.left, rotationSpeed * Time.deltaTime);
	}

}
