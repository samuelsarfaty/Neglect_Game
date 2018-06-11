using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mill : MonoBehaviour {

	public float rotationSpeed;
	public bool isRotating;
	public HouseMill houseMill;

	private BoxCollider myCollider;


	void Awake(){
		isRotating = false;
		myCollider = GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isRotating) {
			transform.Rotate (Vector3.left, rotationSpeed * Time.deltaTime);

			if (!houseMill.isActivated) {
				houseMill.Activate ();
				houseMill.isActivated = true;
			}
		}
			
	}

	public void ResetMill(){
		isRotating = false;
		transform.rotation = Quaternion.Euler (Vector3.zero);
		myCollider.isTrigger = false;
		houseMill.isActivated = false;
		houseMill.DeActivate ();

	}

	void MoveMill(){
		transform.Rotate (Vector3.left, rotationSpeed * Time.deltaTime);
		GetComponent<BoxCollider> ().isTrigger = true;
	}

}
