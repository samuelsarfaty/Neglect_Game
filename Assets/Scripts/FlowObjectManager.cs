using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowObjectManager : MonoBehaviour {

	public GameObject myObject;
	public float spawnNumber;

	//private GameObject[] objectsArray;
	private List<GameObject> objectsList = new List<GameObject>();

	void Start(){
		for (int i = 0; i < spawnNumber; i++) {

			Vector3 spawnPos = new Vector3 (transform.position.x, transform.position.y + i, transform.position.z);
			GameObject obj = Instantiate (myObject, spawnPos, Quaternion.identity);
			obj.transform.parent = this.transform;
			objectsList.Add (obj);
			//obj.gameObject.SetActive (false);

		}
	}

	public void Spawn(){
		foreach (GameObject obj in objectsList) {
			obj.SetActive (true);
		}
	}

}
