using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

	public GameObject[] _enemigos; //lista de enemigos

	void Start () {
		_enemigos = GameObject.FindGameObjectsWithTag ("Malo");
	}

	void Update () {
		ComprobarProxEnemigo ();
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
}
