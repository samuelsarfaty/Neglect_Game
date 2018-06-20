using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {

	private ParticleSystem ps;
	/*public float hSliderValueR = 0.0F;
	public float hSliderValueG = 0.0F;
	public float hSliderValueB = 0.0F;
	public float hSliderValueA = 1.0F;*/

	public Slider rSlider;
	public Slider gSlider;
	public Slider bSlider;

	void Start()
	{
		ps = GetComponent<ParticleSystem>();
	}

	void Update()
	{
		var main = ps.main;
		//main.startColor = new Color(hSliderValueR, hSliderValueG, hSliderValueB, hSliderValueA);
		main.startColor = new Color(rSlider.value, gSlider.value, bSlider.value, 1f);
	}

	/*void OnGUI()
	{

		GUI.Label(new Rect(1050, 40, 100, 30), "Red");
		GUI.Label(new Rect(1050, 70, 100, 30), "Green");
		GUI.Label(new Rect(1050, 100, 100, 30), "Blue");
		GUI.Label(new Rect(1050, 130, 100, 30), "Alpha");

		hSliderValueR = GUI.HorizontalSlider(new Rect(1100, 45, 100, 30), hSliderValueR, 0.0F, 1.0F);
		hSliderValueG = GUI.HorizontalSlider(new Rect(1100, 75, 100, 30), hSliderValueG, 0.0F, 1.0F);
		hSliderValueB = GUI.HorizontalSlider(new Rect(1100, 105, 100, 30), hSliderValueB, 0.0F, 1.0F);
		hSliderValueA = GUI.HorizontalSlider(new Rect(1100, 135, 100, 30), hSliderValueA, 0.0F, 1.0F);
	}*/




}
