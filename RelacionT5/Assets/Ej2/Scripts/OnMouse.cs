using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour {

	bool cambioColor= true;

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
		GetComponent<Renderer> ().material.color = Color.blue;
	}

	void OnMouseExit()
	{
		if (cambioColor) {
			GetComponent<Renderer> ().material.color = Color.white;
		}
	}
}
