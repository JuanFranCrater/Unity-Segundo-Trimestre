using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComunicacionEntreObjetos : MonoBehaviour {
	string[] valores;

	void Start () {
		//Comunicar mensajes de un objeto a otro o aun conjunto de elementos. 
		//SendMessage(nombre del metodo(No tiene que ser publico)) -> Envia a un objeto 
		//BroadcastMessage(nombre del metodo(No tiene que ser publico)) -> Envia a un conjunto de objetos
		valores = new string[]{"Hola","Adios"};
	}

	void Update () {
		//Lanzar mensaje
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject.FindGameObjectWithTag ("Receptor").SendMessage ("MostrarDatos",valores);
		}
	}
}
