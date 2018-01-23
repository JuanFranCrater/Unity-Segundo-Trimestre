using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equalizer : MonoBehaviour {
	static int anchoWindows=320;
	static int altoWindows=300;
	int altoBarra=250;
	public int anchoBarra=15;
	private Rect windowRect ;
	int id = 0;
	string contenido = "Ecualizador";
	float v1SliderValue = -30.0F;
	float v2SliderValue = 65.0F;
	float v3SliderValue = 10.0F;
	float v4SliderValue = -50.0F;
	float v5SliderValue = 22.0F;
	float v6SliderValue = 0.0F;
	float v7SliderValue = -62.0F;
	float v8SliderValue = 55.0F;
	float v9SliderValue = -22.0F;
	float v10SliderValue = 15.0F;
	void OnGUI()
	{
		windowRect = new Rect (Screen.width / 2 - anchoWindows / 2, Screen.height / 2 - altoWindows / 2, anchoWindows, altoWindows);
		windowRect = GUI.Window (id, windowRect, Ventana, contenido);
	}
	void Ventana(int idWindow)
	{
		v1SliderValue = GUI.VerticalSlider(new Rect(25, 25, anchoBarra,altoBarra ), v1SliderValue, 100.0F, -100.0F);
		v2SliderValue = GUI.VerticalSlider(new Rect(55, 25, anchoBarra,altoBarra ), v2SliderValue, 100.0F, -100.0F);
		v3SliderValue = GUI.VerticalSlider(new Rect(85, 25, anchoBarra,altoBarra ), v3SliderValue, 100.0F, -100.0F);
		v4SliderValue = GUI.VerticalSlider(new Rect(115, 25, anchoBarra,altoBarra ), v4SliderValue, 100.0F, -100.0F);
		v5SliderValue = GUI.VerticalSlider(new Rect(145, 25, anchoBarra,altoBarra ), v5SliderValue, 100.0F, -100.0F);
		v6SliderValue = GUI.VerticalSlider(new Rect(175, 25, anchoBarra,altoBarra ), v6SliderValue, 100.0F, -100.0F);
		v7SliderValue = GUI.VerticalSlider(new Rect(205, 25, anchoBarra,altoBarra ), v7SliderValue, 100.0F, -100.0F);
		v8SliderValue = GUI.VerticalSlider(new Rect(235, 25, anchoBarra,altoBarra ), v8SliderValue, 100.0F, -100.0F);
		v9SliderValue = GUI.VerticalSlider(new Rect(265, 25, anchoBarra,altoBarra ), v9SliderValue, 100.0F, -100.0F);
		v10SliderValue = GUI.VerticalSlider(new Rect(295, 25, anchoBarra,altoBarra ), v10SliderValue, 100.0F, -100.0F);

	}
}
