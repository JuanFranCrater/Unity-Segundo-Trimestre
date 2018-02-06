using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcan : MonoBehaviour {

	public GameObject _cubo;
	public float _ratioTiempoLanzamiento=0.5f;

	void Start () {
		//Se inicia una vez en el start
		StartCoroutine ("LanzarCubo");
	}

	void Update () {
		
	}

	IEnumerator LanzarCubo()
	{
		while (true) {
			Instantiate (_cubo, transform.position, Random.rotation);
			yield return new WaitForSeconds (_ratioTiempoLanzamiento);
		}
	}
}
