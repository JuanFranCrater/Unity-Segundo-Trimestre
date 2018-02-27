using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Camera myCamera;
	Vector3 vector;

	void FixedUpdate () {
		vector= myCamera.gameObject.transform.TransformVector (Vector3.forward);
		if (Input.GetAxis ("Vertical")>0||Input.GetAxis("Horizontal")>0) {
			GetComponent<Rigidbody>().AddForce(vector*Input.GetAxis("Vertical"));
			GetComponent<Rigidbody>().AddForce(Vector3.right*Input.GetAxis("Horizontal"));
		}
	}
}
