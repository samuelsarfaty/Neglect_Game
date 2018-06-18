using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	[Range(0,3)]
	public float animDuration;

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			transform.Rotate (new Vector3 (0, 90, 0));
		} else if (Input.GetMouseButtonDown (1)) {
			Destroy (transform.parent.gameObject);
		}
	}

	void Start(){
		StartCoroutine (SpawnAnim(Vector3.zero, animDuration));
	}

	IEnumerator SpawnAnim(Vector3 destination, float duration){
		Vector3 currentPos = transform.localPosition;
		float progress = 0f;
		float startTime = Time.time;

		while (progress < 1f) {
			progress = (Time.time - startTime) / duration;
			transform.localPosition = Vector3.Lerp (currentPos, destination, progress);
			yield return null;
		}

	}
}
