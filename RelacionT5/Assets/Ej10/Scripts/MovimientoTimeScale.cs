using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTimeScale : MonoBehaviour {

	Rigidbody _rgb;
	// Use this for initialization
	void Start () {
		_rgb = GetComponent<Rigidbody> ();

	}

	void FixedUpdate()
	{
		_rgb.AddForce(new Vector3(Input.GetAxis ("Horizontal")*50,0,Input.GetAxis("Vertical")*50));
	}
}
