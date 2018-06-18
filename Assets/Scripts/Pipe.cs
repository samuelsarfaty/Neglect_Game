using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	private static float spawnDuration;
	private static float rotationDuration;

	private bool isMoving;

	void Awake(){
		isMoving = false;
		spawnDuration = 0.3f;
		rotationDuration = 0.3f;
	}



	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			Vector3 rotTarget = new Vector3 (transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y + 90f, transform.localRotation.eulerAngles.z);
			StartCoroutine(RotateMe(Quaternion.Euler(rotTarget), rotationDuration));
			//StartCoroutine(RotateMe(Quaternion.Euler(new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y + 90f, transform.localRotation.eulerAngles.z)), rotationDuration));
		
		} else if (Input.GetMouseButtonDown (1)) {
			Destroy (transform.parent.gameObject);
		}
	}

	void Start(){
		StartCoroutine (SpawnAnim(Vector3.zero, spawnDuration));
	}

	IEnumerator SpawnAnim(Vector3 destination, float duration){
		if (!isMoving) {
			isMoving = true;
			Vector3 currentPos = transform.localPosition;
			float progress = 0f;
			float startTime = Time.time;

			while (progress < 1f) {
				progress = (Time.time - startTime) / duration;
				transform.localPosition = Vector3.Lerp (currentPos, destination, progress);
				yield return null;
			}
		}

		isMoving = false;
	}

	/*IEnumerator RotateMe(Vector3 byAngles, float duration){
		if (!isMoving) {
			isMoving = true;
			var fromAngle = transform.rotation;
			var toAngle = Quaternion.Euler (transform.eulerAngles + byAngles);

			for (float t = 0; t <= 1; t += Time.deltaTime / duration) {
				transform.rotation = Quaternion.Slerp (fromAngle, toAngle, t);
				yield return null;
			}
		}

		isMoving = false;
	}*/

	IEnumerator RotateMe(Quaternion destination, float duration){
		if (!isMoving) {
			isMoving = true;
			Quaternion startAngle = transform.localRotation;
			float progress = 0f;
			float startTime = Time.time;

			while (progress < 1f) {
				progress = (Time.time - startTime) / duration;
				transform.localRotation = Quaternion.Slerp (startAngle, destination, progress);
				yield return null;
			}
			isMoving = false;
		}
			
	}
}
