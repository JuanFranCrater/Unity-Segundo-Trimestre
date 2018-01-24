using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

		private Rect windowRect = new Rect ((Screen.width)/2-110, (Screen.height)/2-25, 220, 50);
		int idWindow=0;
		string mensaje="¿Desea Salir?";

		private bool show = false;

		void Update()
		{
			if (Input.GetKeyDown (KeyCode.Escape)) {
				show = !show;
			}
		}
		void OnGUI () 
		{
		if (show) {
			Time.timeScale = 0;
			DisableAllScripts ();
			windowRect = GUI.Window (idWindow, windowRect, DialogWindow, mensaje);
		} else {
			if(Time.timeScale==0)
			{
				Time.timeScale = 1;
				ActivateAllScripts ();
				show = false;
			}
		}
		}

		void DialogWindow (int windowID)
		{
			float y = 20;
		if(GUI.Button(new Rect(5,y, windowRect.width/2-10, 20), "Si"))
			{
				Application.Quit ();
				show = false;
			}

		if(GUI.Button(new Rect(windowRect.width/2+5,y, windowRect.width /2-10, 20), "No"))
			{
				Time.timeScale = 1;
				ActivateAllScripts ();
				show = false;
			}
		}
	void DisableAllScripts()
	{
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("controladores")) {
			MonoBehaviour[] scripts = go.GetComponents<MonoBehaviour> ();
			foreach (MonoBehaviour script in scripts) {
				script.enabled = false;
			}
		}
	}
	void ActivateAllScripts()
	{
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("controladores")) {
			MonoBehaviour[] scripts = go.GetComponents<MonoBehaviour> ();
			foreach (MonoBehaviour script in scripts) {
				script.enabled = true;
			}
		}
	}
	}
