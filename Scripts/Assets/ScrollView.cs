using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollView : MonoBehaviour {
	
	Vector2 posMostrarScrollView = new Vector2 (10, 10);
	string contenido = "Este es el textodel contenido del ScrollView";
	public Rect posMostrarArea = new Rect (25,25,120,120);
	public Rect posMostrarContendido = new Rect (0,0,400,400);

	void OnGUI () {
		posMostrarScrollView=GUI.BeginScrollView (posMostrarArea, posMostrarScrollView, posMostrarContendido);
		GUI.TextArea (new Rect (0, 0, 400, 400), contenido);
		GUI.Button (new Rect (10, 20, 100, 30), "PUlsame");
		GUI.EndScrollView ();
	}

}
