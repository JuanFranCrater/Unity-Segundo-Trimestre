using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour {

	public Camera myCamera;
	 float horizontalSpeed=0;
	 float verticalSpeed;
	void Update () {
		transform.Rotate (0,horizontalSpeed*Input.GetAxis("Mouse X"),0);
		//myCamera.transform.Rotate (-verticalSpeed*Input.GetAxis("Mouse Y"),0,0); Disparar arriba y abajo no hace falta creo yo
	}
	void Iniciar()
	{
		horizontalSpeed = 5;
	}
	void Morir()
	{
		horizontalSpeed = 0;
	}

}
