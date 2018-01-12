using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gui : MonoBehaviour {
	int i=0;
	string textoMostrar = "Soy el texto de ejemplo";
	bool showLabel;
	bool rightClickPulsada;
	string textoIni="Escribe algo";

	bool space;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			space = !space;
		}

		if (Input.GetMouseButtonDown(1)) {
			rightClickPulsada = !rightClickPulsada;
		}
		//if(showLabel)
		//i++;
	}
	//Interfaz Grafica, es el metodo que mas se ejecuta
	public void OnGUI()
	{
		//textoIni = GUI.TextField (new Rect (10, 120, 300, 30), textoIni);
		textoIni = GUI.TextArea (new Rect (10, 120, 300, 100), textoIni);
		if(showLabel)
		MostrarLabel ();
		if (rightClickPulsada)
		MostrarButton ();
		if (space)
			MostrarRepiteBoton ();
	}
	void MostrarButton()
	{
		
		if (GUI.Button (new Rect (10, 10, 100, 20), new GUIContent("Texto del boton","Contenido del ToolTip"))) {
			showLabel = !showLabel;
		}
		GUI.Label(new Rect(10, 40, 100, 40), GUI.tooltip);
	}

	void MostrarRepiteBoton()
	{
		if (GUI.RepeatButton (new Rect (10, 80, 100, 20), new GUIContent("RepeatButton","ToolTip de RepeatButton"))) {
			showLabel = !showLabel;
		}
		GUI.Label(new Rect(10, 100, 100, 40), GUI.tooltip);
	}
	void MostrarLabel()
	{
		int anchoCaracter = 6;
		float x = (float)Screen.width / 2 - textoMostrar.Length * anchoCaracter / 2;
		float y = 50;
		float ancho = 300;
		float alto = 20;
		Rect rect = new Rect (x, y, ancho, alto);
		GUI.color = Color.red;
		//GUI.Label (rect, textoMostrar+i.ToString());
		GUI.Label (rect, textoIni);
	}
}
