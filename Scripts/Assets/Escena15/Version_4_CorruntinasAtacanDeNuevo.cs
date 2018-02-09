using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version_4_CorruntinasAtacanDeNuevo : MonoBehaviour {
	
	const int NCUBOS = 3;
	GameObject[] cubos = new GameObject[NCUBOS];
	float destinoX =4;
	Vector3 velocidad = new Vector3(0.05f,0,0);
	Vector3 velocidadRotacion = new Vector3(0,0,5f);
	// Use this for initialization
	void Start () {
		LocateCubes ();
		StartCoroutine ("MoverCubos");
	}
	void LocateCubes()
	{
		cubos [0] = GameObject.Find ("Cube1");
		cubos [1] = GameObject.Find ("Cube2");
		cubos [2] = GameObject.Find ("Cube3");
	}

	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator MoverCubo(GameObject cuboTmp)
	{
		while(cuboTmp.GetComponent<Transform>().position.x <destinoX)
		{
			cuboTmp.GetComponent<Transform> ().Translate (velocidad.x, velocidad.y, velocidad.z);
			yield return null;
		}
	}
	IEnumerator MoverCubos()
	{
		// Mueve cubo a cubo hasta el destino
		foreach (GameObject cuboTmp in cubos) {
			yield return StartCoroutine(MoverCubo(cuboTmp));

			cuboTmp.GetComponent<MeshRenderer> ().material.color = Color.blue;

			yield return StartCoroutine (RotarCubos (cuboTmp));
		}
	}
	IEnumerator RotarCubos(GameObject cuboTmp)
	{
		// Rota cada cubo al llegar al destino
		while(cuboTmp.GetComponent<Transform>().rotation.eulerAngles.z < 90)
		{
			Vector3 anguloActual = cuboTmp.transform.rotation.eulerAngles;
			cuboTmp.GetComponent<Transform> ().rotation = Quaternion.Euler (anguloActual + velocidadRotacion);
			yield return null;
		}
	}

}
