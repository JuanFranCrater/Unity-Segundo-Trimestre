using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version_2_Corrutinas : MonoBehaviour {

	const int NCUBOS = 3;
	GameObject[] cubos = new GameObject[NCUBOS];
	float destinoX =4;
	Vector3 velocidad = new Vector3(0.05f,0,0);

	void Start () {
		LocateCubes ();
		StartCoroutine ("MoverCubos");
	}

	void Update () {

	}
	void LocateCubes()
	{
		cubos [0] = GameObject.Find ("Cube1");
		cubos [1] = GameObject.Find ("Cube2");
		cubos [2] = GameObject.Find ("Cube3");
	}
		
	IEnumerator MoverCubos()
	{
		foreach (GameObject cuboTmp in cubos) {
			while(cuboTmp.GetComponent<Transform>().position.x <destinoX)
			{
				cuboTmp.GetComponent<Transform> ().Translate (velocidad.x, velocidad.y, velocidad.z);
				yield return null;
			}
		}
	}
}
