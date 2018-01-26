using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	int botonClicked = 0;
	string[] listaDeBotones = { "Uno", "Dos", "Tres" };
	string contenidoTexto = "Modificame...";

	void OnGUI()
	{
		contenidoTexto = GUI.TextField (new Rect (10, 10, 300, 30), contenidoTexto,30);

		if (GUI.changed) {
			Debug.Log ("Ha cambido el texto");
		}

		/*
		//Detectar el botón pulsado
		botonClicked= GUI.Toolbar(new Rect(10,10,120,75),botonClicked,listaDeBotones);
		if (GUI.changed) {
			Debug.Log ("Has hecho un click en un boton");
			switch (botonClicked) {

			case 0:
				Debug.Log ("Boton 0");
				break;
			case 1:
				Debug.Log ("Boton 1");
				break;
			case 2:
				Debug.Log ("Boton 2");
				break;
			}
		}
		*/


	}
}
