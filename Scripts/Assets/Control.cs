using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	public GameObject _otro;
	public Transform[] _enemigos;

	public Transform _padre;

	Rigidbody _rgb;
	Renderer _rd;

	void Awake()
	{
		_rgb = GetComponent<Rigidbody> ();	
		_rd = GetComponent<Renderer> ();
	}
	void Start () 
	{
		int i = 0;
		foreach (Transform tmp in _padre.transform) {
			i++;
			Debug.Log ("Hijo: "+i+" , "+"Nombre: "+tmp.name);
		}
		_padre.transform.Find ("Sphere").GetComponent<Renderer>().material.color=Color.magenta;
		_rgb.mass = 10F;
		_rd.material.color = Color.blue;
		//_otro.transform.localScale = new Vector3 (2F, 2F, 2F);
		_otro.GetComponent<Transform> ().localScale = new Vector3 (3F, 3F, 3F);
	}
}
