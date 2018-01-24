using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
	Rigidbody _rgb;
	// Use this for initialization
	void Start () {
		_rgb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_rgb.AddForce(new Vector3(Input.GetAxis ("Horizontal"),0,Input.GetAxis("Vertical")));
		transform.localRotation = new Quaternion(0,0,0,0);
		}
}
