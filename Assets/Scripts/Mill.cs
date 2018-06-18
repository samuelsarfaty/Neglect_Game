using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mill : MonoBehaviour {

	public float rotationSpeed;
	public bool isRotating;
	public HouseMill houseMill;

	private BoxCollider myCollider;
	private AudioSource source;
	private BoxCollider myCol;


	void Awake(){
		isRotating = false;
		myCollider = GetComponent<BoxCollider> ();
		source = GetComponent<AudioSource> ();
		myCol = GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isRotating) {
			transform.Rotate (Vector3.left, rotationSpeed * Time.deltaTime); //Only run this after ActivateMill() has been called

			if (!houseMill.isActivated) {
				//houseMill.Activate ();
				houseMill.Invoke ("Activate", 1);
				//houseMill.isActivated = true;
			}
		}
			
	}

	public void ResetMill(){
		isRotating = false;
		transform.rotation = Quaternion.Euler (Vector3.zero);
		myCollider.isTrigger = false;
		//houseMill.isActivated = false;
		houseMill.DeActivate ();
		source.Stop ();

	}

	public void ActivateMill(){
		myCol.isTrigger = true;
		source.Play ();
		isRotating = true;
	}

}
