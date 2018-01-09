using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTheChildren : MonoBehaviour {
	
	Transform[] _enemigos;
	Transform[] _hijos;
	public GameObject _padre;
	int i=0;

	void Start () {
		_hijos = _padre.transform;
		foreach (Transform tmp in _hijos) {
			if (tmp.tag.Equals ("Malo")) {
				_enemigos.SetValue (tmp, i++);
			}
		}
		foreach (Transform tmp in _enemigos) {
			tmp.GetComponent<Renderer> ().material.color = Color.red;
		}
	}

	void Update () {
		
	}
}
