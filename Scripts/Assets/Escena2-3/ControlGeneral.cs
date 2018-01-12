using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlGeneral : MonoBehaviour {

	public Text _textoMostrado;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		//GetComponent<Renderer> ().material.color = Color.black;
	}
	public void OnMouseEnter()
	{
		GetComponent<Renderer> ().material.color = Color.red;
		_textoMostrado.text="OnMouseEnter.. Rojo";
	}
	public void OnMouseExit()
	{
		GetComponent<Renderer> ().material.color = Color.blue;
		_textoMostrado.text="OnMouseExit.. Azul";
	
		
	}
	public void OnMouseOver()
	{
		//GetComponent<Renderer> ().material.color = Color.green;
	}



}
