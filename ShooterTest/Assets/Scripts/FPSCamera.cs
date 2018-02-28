using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour {

	public Camera myCamera;
	public float horizontalSpeed;
	public float verticalSpeed;
	void Update () {
		transform.Rotate (0,horizontalSpeed*Input.GetAxis("Mouse X"),0);
		//myCamera.transform.Rotate (-verticalSpeed*Input.GetAxis("Mouse Y"),0,0); Disparar arriba y abajo no hace falta creo yo
	}

}
