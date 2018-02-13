using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	Renderer _texturaObjeto;

	void Start () {
		_texturaObjeto = GetComponent<Renderer> ();	
	}
	
	public void Detectado()
	{
		//Hago cosassssssss
		_texturaObjeto.material.color=Color.blue;
	}
	public void NoDetectado()
	{
		//Hago cosassssssss
		_texturaObjeto.material.color=Color.red;
	}
}
