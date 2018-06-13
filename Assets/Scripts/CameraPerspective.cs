using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspective : MonoBehaviour {

	//Perspective view values
	[Header("Perspective camera position")]
	public float persPosX;
	public float persPosY;
	public float persPosZ;

	[Header("Perspective camera rotation")]
	public float persRotX;
	public float persRotY;
	public float persRotZ;

	private Vector3 persPosition;
	private Quaternion persRotation;

	//Top-down view values
	[Header("Top-down camera position")]
	public float tdPosX;
	public float tdPosY;
	public float tdPosZ;

	[Header("Top-down camera rotation")]
	public float tdRotX;
	public float tdRotY;
	public float tdRotZ;

	private Vector3 tdPosition;
	private Quaternion tdRotation;

	public bool isCameraPerspective;


	void Awake(){
		persPosition = new Vector3 (persPosX, persPosY, persPosZ);
		persRotation = Quaternion.Euler(new Vector3(persRotX,persRotY,persRotZ));

		tdPosition = new Vector3 (tdPosX, tdPosY, tdPosZ);
		tdRotation = Quaternion.Euler (new Vector3 (tdRotX, tdRotY, tdRotZ));

		isCameraPerspective = true;
	}

	// Use this for initialization
	void Start () {

		transform.position = persPosition;
		transform.rotation = persRotation;
	}

	public void SwitchCamera(){
		if (isCameraPerspective) {
			transform.position = tdPosition;
			transform.rotation = tdRotation;
			isCameraPerspective = false;
		} else {
			transform.position = persPosition;
			transform.rotation = persRotation;
			isCameraPerspective = true;
		}
	}

}
