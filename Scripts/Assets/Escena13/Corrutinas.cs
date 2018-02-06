using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour {

	public GameObject obj;
	void Start () {
		//obj.GetComponent<Rigidbody> ().useGravity = false;
	}
	//Unity no permite Hilos, pero con las corrutinas podemos simular su uso.
	//yield return null; para la routina
	//yield break; para la routina totalmente
	//yield new WaitForSeconds(tiempo en segundos);
	//yield new WaitEndOfFrame()-> espera al frame

	void Update () {
		/*if (Input.GetKey (KeyCode.Space)) {
			StartCoroutine ("Fade");
		} else {
			StopCoroutine ("Fase");
		}*/
			
	}
	/*
	IEnumerator Fade() {
		Debug.Log ("Hola");
		obj.GetComponent<Rigidbody> ().AddForce (Vector3.up,ForceMode.Force);
		yield return null;}
		*/
	}
