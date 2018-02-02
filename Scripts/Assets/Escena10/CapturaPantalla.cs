using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CapturaPantalla : MonoBehaviour {

	//Capturas 
	string carpetaCapturas = "Capturas";
	int frameRate= 25;

	void Start () {
		Time.captureFramerate = frameRate;
		System.IO.Directory.CreateDirectory (carpetaCapturas);
	}

	void Update () {
		string nombre = string.Format ("{0}/{1:D04}_pantallazo.png",carpetaCapturas,Time.frameCount);
		Application.CaptureScreenshot (nombre);
	}

}
