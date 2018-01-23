using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showGUI : MonoBehaviour {

	bool mostrar=false;
	string textoMostrar="Soy el mensaje mostrado con GUI.Label";
	void Start () {
		
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			mostrar = !mostrar;
		}
	}
	void mostratLabel ()
	{
		GUI.skin.label.fontSize = 25;
		int anchoCaracter = 12;
		float x = (float)Screen.width / 2 - (textoMostrar.Length * anchoCaracter / 2);
		float y = (float)Screen.height / 2;
		float ancho = 500;
		float alto = 35;
		Rect rect = new Rect (x, y, ancho, alto);
		GUI.color = Color.cyan;
		GUI.Label (rect, textoMostrar);
	}

	void OnGUI()
	{
		if(mostrar)
		mostratLabel ();
	}
}
