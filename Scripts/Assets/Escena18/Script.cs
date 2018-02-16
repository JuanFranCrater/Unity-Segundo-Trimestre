using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

	GameObject[] _enemigos; //lista de enemigos

	void Start () {
		_enemigos = GameObject.FindGameObjectsWithTag ("Malo");
		StartCoroutine (ComprobarProxEnemigoCorrutina ());
	}

	void Update () {
		//V1. ->ComprobarProxEnemigo ();
	}

	//ver.1 Comprobar la proximidad del enemigo

	void ComprobarProxEnemigo()
	{
		float maxDistPermitida = 1.5f;

		foreach (GameObject enemigotmp in _enemigos) {
			if (Vector3.Distance (enemigotmp.transform.position, transform.position) < maxDistPermitida) {
				enemigotmp.SendMessage ("Detectado");
			} else {
				enemigotmp.SendMessage ("NoDetectado");
			}
		}
	}
	IEnumerator ComprobarProxEnemigoCorrutina()
	{
		float maxDistPermitida = 1.5f;
		while (true) {
			foreach (GameObject enemigotmp in _enemigos) {
				if (Vector3.Distance (enemigotmp.transform.position, transform.position) < maxDistPermitida) {
					enemigotmp.SendMessage ("Detectado");
				} else {
					enemigotmp.SendMessage ("NoDetectado");
				}
			}
			yield return new WaitForSeconds (0.02f);
		}
	}
}
