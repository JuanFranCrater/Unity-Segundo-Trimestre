using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Button iniciar;
	public Button salir;
	public GameObject spawner;
	public GameObject tirador;

	public void Iniciar()
	{
		iniciar.enabled = false;
		salir.enabled = false;
		Instantiate (spawner);
		Instantiate (tirador);
		GameObject.Find ("Menu").SendMessage ("PuntosYTiempoACero");
	}
	public void Salir()
	{
		Application.Quit ();
	}
	void AbrirMenu()
	{
		iniciar.enabled = true;
		salir.enabled = true;
		Destroy(GameObject.Find("Spawner"));
		Camera.main.enabled = true;
	}
}
