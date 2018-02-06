using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptor2 : MonoBehaviour {
	float scala;
	// Use this for initialization
	void Start () {
		scala = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void ReceptorMensaje(GameObject obj)
	{
		//Activar el obj recivido
		obj.SetActive(true);
		obj.AddComponent<Rigidbody> ();
		obj.GetComponent<Rigidbody> ().AddForce (Vector3.up * 10, ForceMode.Impulse);
	}
}
