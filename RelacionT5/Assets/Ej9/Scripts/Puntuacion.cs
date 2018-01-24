using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {
	string mensaje="";
	int puntuacion =50;
	string lastTag="";
	string lastObject="";
	GameObject[] tipo1;
	GameObject[] tipo2;
	GameObject[] tipo3;
	GameObject[] tipo4;
	bool derrota=false;
	bool victoria = false;
	void Update () {
		
		if (puntuacion == 0) {
			mostrarDerrota ();
		} else if (!quedanObjetos ()) {
			mostrarVictoria ();
		} else {
			mensaje = puntuacion.ToString();
		}
	}
	void mostrarDerrota()
	{
		derrota = true;
	}
	void mostrarVictoria()
	{
		victoria = true;
	}
	bool quedanObjetos()
	{
		tipo1 = GameObject.FindGameObjectsWithTag ("Puntos_2");
		if (tipo1.Length > 0) {
			return true;
		}
		tipo2 = GameObject.FindGameObjectsWithTag ("Puntos_3");
		if (tipo2.Length > 0) {
			return true;
		}
		tipo3 = GameObject.FindGameObjectsWithTag ("Puntos_4");
		if (tipo3.Length > 0) {
			return true;
		}
		tipo4 = GameObject.FindGameObjectsWithTag ("Puntos_5");
		if (tipo4.Length > 0) {
			return true;
		}
		return false;
	}
	void OnGUI()
	{
		if(!derrota&&!victoria)
		GUI.Label(new Rect(20,20,mensaje.Length*20,45),mensaje);

		if (derrota) {
			mensaje = "Has perdido";
			GUI.Label (new Rect (20, 20, mensaje.Length * 20, 45), mensaje );
		}

		if(victoria){
			mensaje = "Has ganado";
			GUI.Label(new Rect(20,20,mensaje.Length*20,45),mensaje);
		}
	}
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("Colision");
		string actualTag = collision.gameObject.tag;
		if (actualTag == lastTag) {
			puntuacion -= int.Parse(actualTag.Substring (7, 1));
			lastTag = actualTag;
			lastObject = getTipoObjetoByTag (lastTag);
		} else {
			if(getTipoObjetoByTag(actualTag)==lastObject){
				//?????????
				lastTag = actualTag;
				lastObject = getTipoObjetoByTag (lastTag);
			}else if(getTipoObjetoByTag(actualTag)!=lastObject){
				puntuacion += int.Parse(actualTag.Substring (7, 1));
				lastTag = actualTag;
				lastObject = getTipoObjetoByTag (lastTag);
				Destroy (collision.gameObject);
			}
		}


	}
	string getTipoObjetoByTag(string tag)
	{
		if (tag.Equals ("Puntos_2")) {
			return "esfera";
		}
		if (tag.Equals ("Puntos_3")) {
			return "cubo";
		}
		if (tag.Equals ("Puntos_4")) {
			return "esfera";
		}
		if (tag.Equals ("Puntos_5")) {
			return "cubo";
		}
		return "";
	}
}
