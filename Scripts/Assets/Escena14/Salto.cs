using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto: MonoBehaviour {

	float velocidad=4.5f;
	Vector3 anguloRotacion = new Vector3(0.33f,0.33f,0.33f);
	float fuerzaImpulso;
	void Start () {
		fuerzaImpulso = 5f;
		GetComponent<Rigidbody> ().AddForce (Vector3.up*fuerzaImpulso,ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (anguloRotacion * velocidad);
	}
}
