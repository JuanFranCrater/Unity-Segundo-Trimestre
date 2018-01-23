using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formulario : MonoBehaviour {
	static int anchoWindows=320;
	static int altoWindows=250;
	string nombre="";
	string apellidos="";
	string edad="";
	string mensaje="";
	string txvnombre="Nombre";
	string txvApellidos="Apellidos";
	string txvEdad="Edad";
	private Rect windowRect ;
	string contenido="Datos del usuario";
	int id=0;
	void OnGUI()
	{
		windowRect = new Rect (Screen.width / 2 - anchoWindows / 2, Screen.height / 2 - altoWindows / 2, anchoWindows, altoWindows);
		windowRect = GUI.Window (id, windowRect, Ventana, contenido);
	}
	void Ventana(int idWindow)
	{
		GUI.Label (new Rect (10, 45, 200, 35), txvnombre);
		GUI.Label (new Rect (10, 80, 200, 35), txvApellidos);
		GUI.Label (new Rect (10, 120, 200, 35), txvEdad);
		nombre = GUI.TextField(new Rect(120, 45, 185, 30), nombre, 25);
		apellidos=GUI.TextField(new Rect(120, 80, 185, 30), apellidos, 25);
		edad=GUI.TextField(new Rect(120, 120, 185, 30), edad, 25);
		edad = Regex.Replace (edad, "[^0-9]", "");
		if(GUI.Button(new Rect(10,160,anchoWindows-25,25),"Enviar"))
		{
			mensaje="Enviando...";
		}
		if(GUI.Button(new Rect(10,190,anchoWindows-25,25),"Limpiar"))
		{
			nombre="";
			apellidos="";
			edad="";
			mensaje = "";
		}
		GUI.Label (new Rect (10, 220, 200, 30), mensaje);
	}

}
