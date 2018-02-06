using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emisor2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Creo un Cubo para pasarlo como parámetro
			GameObject unCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
			unCubo.SetActive (false);
			unCubo.name="Mi Cubo";
			GameObject.FindGameObjectWithTag ("Receptor").SendMessage ("ReceptorMensaje", unCubo);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			GameObject obj = GameObject.Find ("Padre");
			obj.BroadcastMessage ("ReceptorBroadcast");
		}
	}
}
