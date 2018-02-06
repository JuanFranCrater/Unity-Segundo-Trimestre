using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version_1_UsandoIf : MonoBehaviour {

	const int NCUBOS = 3;
	GameObject[] cubos = new GameObject[NCUBOS];
	float destinoX =4;
	Vector3 velocidad = new Vector3(0.05f,0,0);

	void Start () {
		LocateCubes ();
	}

	void Update () {
		MoverCubos ();
	}
	void LocateCubes()
	{
		cubos [0] = GameObject.Find ("Cube1");
		cubos [1] = GameObject.Find ("Cube2");
		cubos [2] = GameObject.Find ("Cube3");
	}

	void MoverCubos()
	{
		//Desplaza cada cubo hasta el final de su recorrido 
		if (cubos [0].GetComponent<Transform> ().position.x < destinoX) {
			cubos [0].GetComponent<Transform> ().Translate (velocidad.x, velocidad.y, velocidad.z);
		}
	}
}
