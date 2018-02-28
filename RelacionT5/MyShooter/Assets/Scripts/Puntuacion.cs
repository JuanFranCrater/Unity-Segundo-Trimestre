using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {

	int muertos=0;
	float tiempo=0;
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width - 200, 0, 200, 200), "Points: "+muertos);
		GUI.Label (new Rect (0, 0, 200, 200), TimeFormater(Time.time-tiempo));
	}
	void MasPuntos()
	{
		muertos += 10;
	}
	string TimeFormater(float tiempo)
	{
		int tiempoTotal = (int)tiempo;
		int minutos = tiempoTotal / 60;
		int segundos= tiempoTotal%60;
		string formato=string.Format ("{0}:{1:00}",minutos,segundos);
		return formato;
	}

	void PuntosYTiempoACero()
	{
		tiempo = Time.time;
		muertos = 0;
	}
}
