using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor2 : MonoBehaviour {

	public GameObject[] objetos;

	void Start () {
		if(objetos.Length>0)
		{
			for (int i = 0; i < objetos.Length; i++) {
				objetos [i].AddComponent<OnMouseRandom> ();
				objetos[i].tag="controladores";
			}
		}
	}
}
