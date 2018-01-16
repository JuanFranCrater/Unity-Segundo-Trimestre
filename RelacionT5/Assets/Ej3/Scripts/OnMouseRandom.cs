using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseRandom : MonoBehaviour {

	bool cambioColor= true;
	bool colorCambiado=false;
	void Start()
	{
		GetComponent<Renderer> ().material.color=Color.white;
	}

	void OnMouseDown()
	{
		cambioColor = !cambioColor;
	}

	void OnMouseOver()
	{
		if (!colorCambiado) {
			GetComponent<Renderer> ().material.color = randColor ();
			colorCambiado = true;
		}
	}

	void OnMouseExit()
	{
		if (cambioColor) {
			colorCambiado = false;
			GetComponent<Renderer> ().material.color = Color.white;
		}
	}

	Color randColor()
	{
			Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
		return newColor;
	}
}
