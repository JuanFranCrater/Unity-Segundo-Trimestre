using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyleGUI : MonoBehaviour {

	public GUIStyle estilo;
	public GUISkin piel;
	//https://assetstore.unity.com/packages/2d/gui/necromancer-gui-366
	//https://forum.unity.com/threads/custom-skins.7174/

	void OnGUI()
	{
		//CambiarAspecto ();	
		//StylePublic();
		Piel();
	}

	void CambiarAspecto()
	{
		GUI.Label (new Rect (10, 10, 200, 50), "Soy un Label Camuflado a caja", "box");
		GUI.Button (new Rect (10, 80, 180, 50), "Soy el boton camufaldo \na Toggle", "toggle");
	}
	void Piel()
	{
		GUI.skin = piel;
		GUI.Button (new Rect (10, 80, 180, 50), "Soy un boton con estilo", "button");
	}
	void StylePublic()
	{
		
	}
}
