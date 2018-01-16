using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionGUI : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		_luz = GameObject.Find ("Directional Light");
	}

	public Texture _icono;
	public int alto = 100;
	public int ancho = 100;
	void onButton()
	{
		Rect pos = new Rect (Screen.width/2-ancho/2,Screen.height/2-alto/2,ancho,alto);
		GUI.Button (pos, new GUIContent("Pulsame", _icono));
	}

	GameObject _luz;
	bool _toggle=true;
	public int altoTog = 100;
	public int anchoTog = 100;
	void onToddler()
	{
		Rect posToddler = new Rect (Screen.width / 2 - anchoTog / 2, (Screen.height / 2 - altoTog / 2)-70, anchoTog, altoTog);
		_toggle=GUI.Toggle (posToddler, _toggle, "Luz");
		if (_luz != null) {
			_luz.GetComponent<Light> ().enabled = _toggle;
		}
	}

	int nBotonActivo;
	string[] listaBotones = { "Boton1", "Boton2", "Boton3" };
	public int altoTool = 50;
	public int anchoTool = 200;
	void onToolBar()
	{
		Rect posToolbar = new Rect (10,10, anchoTool, altoTool);
		nBotonActivo = GUI.Toolbar (posToolbar, nBotonActivo, listaBotones);
	}

	int nBotonActivo2;
	public int altoGrid = 50;
	public int anchoGrid = 200;
	public Texture[] _texturas;
	public int nColumnas=2;
	void onGrid()
	{
		Rect posGrid = new Rect (Screen.width-anchoGrid,Screen.height-altoGrid, anchoGrid, altoGrid);
		nBotonActivo2 = GUI.SelectionGrid (posGrid, nBotonActivo2, _texturas, nColumnas);	
	}

	float valorActualH;
	void onHorizontalSlider()
	{
		
		Rect pos = new Rect (70, 70, 100, 100);
		valorActualH = GUI.HorizontalSlider (pos, 0f, 0f, 100f);
	}

	float valorActualV;
	void onVerticalSlider()
	{
		
		Rect pos = new Rect (70, 100, 100, 100);
		valorActualV = GUI.VerticalSlider (pos, 0f, 0f, 100f);
	}

	void OnGUI()
	{
		onButton ();

		onToddler ();

		onToolBar ();

		onGrid ();

		onHorizontalSlider ();

		onVerticalSlider ();

	}
}
