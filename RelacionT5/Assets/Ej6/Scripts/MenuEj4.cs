using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEj4 : MonoBehaviour {

	static int ancho=200;
	static int alto=100;
	private Rect windowRect = new Rect (Screen.width/2-ancho/2, Screen.height/2-alto/2, ancho, alto);
	int id = 0;
	string contenido = "Menu arrastable";

	void OnGUI()
	{
		windowRect = GUI.Window (id, windowRect, Ventana, contenido);
	}
	void Ventana(int idWindow)
	{
		GUI.DragWindow (new Rect (0, 0, 10000, 20));

		if (GUI.Button(new Rect(ancho/2-50,20,100,20), "Ejercicio 2")) {
			SceneManager.LoadScene ("EscenaEj2");
		}
		if (GUI.Button(new Rect(ancho/2-50,45,100,20), "Ejercicio 3")) {
			SceneManager.LoadScene ("EscenaEj3");
		}
		if (GUI.Button(new Rect(ancho/2-50,70,100,20), "Ejercicio 4")) {
			SceneManager.LoadScene ("EscenaEj4");
		}
	}
}
