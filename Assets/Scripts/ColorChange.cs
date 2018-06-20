using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {

	public Slider rSlider;
	public Slider gSlider;
	public Slider bSlider;

	private ParticleSystem ps;

	void Start(){
		ps = GetComponent<ParticleSystem>();
	}

	void Update(){
		var main = ps.main;
		main.startColor = new Color(rSlider.value, gSlider.value, bSlider.value, 1f);
	}
}
