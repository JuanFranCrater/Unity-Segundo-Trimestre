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
		if(_texturaObjeto!=null)
		_texturaObjeto.material.color=Color.blue;
	}
	public void NoDetectado()
	{
		if(_texturaObjeto!=null)
		_texturaObjeto.material.color=Color.red;
	}
}
