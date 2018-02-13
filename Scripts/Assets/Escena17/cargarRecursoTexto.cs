using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cargarRecursoTexto : MonoBehaviour {

	string url ="http://www.ascii-art.de/ascii/ghi/highlander.txt";


	void Start () {
		StartCoroutine (CargarTexto ());
	}


	void Update () {
		
	}

	IEnumerator CargarTexto()
	{
		Text _textUI = GetComponent<Text> ();
		_textUI.text = "Cargardo el fichero ...";
		WWW _www = new WWW (url);
		yield return _www;
		string contenido = _www.text;
		_textUI.text = contenido;
	}

}
