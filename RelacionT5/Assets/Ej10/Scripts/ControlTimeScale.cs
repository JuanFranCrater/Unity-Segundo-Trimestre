using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTimeScale : MonoBehaviour {

	string mensaje;
	void Start()
	{
		Time.timeScale = 1;
	}
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Time.timeScale = 0;
		}
		if (Input.GetKey (KeyCode.A)) {
			Time.timeScale = 1;
		}
		mensaje = Time.timeScale.ToString ();
	}
	void OnGUI()
	{
		GUI.Label(new Rect(20,20,mensaje.Length*20,45),mensaje);
	}
}
