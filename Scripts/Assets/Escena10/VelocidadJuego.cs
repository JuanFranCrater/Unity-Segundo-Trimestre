using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadJuego : MonoBehaviour {

	Vector3 posIniObj;
	Vector3 posActObj;
	float posXAct;
	float posYAct;
	float poszAct;
	float velocidad = 0.5f;
	float minimoX = -4.5f;
	float MaximoX = 4.5f;
	float minimoZ= -4.5F;
	float MaximoZ= 4.5f;
	float velRotacion= 2.5f;

	bool pulsado=false;
	void Start () {
		//Al detener el juego el fixed update para y el update no, a meno sque multipliquemos por Time.DeltaTime. La musica sigue sonando. 
	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			pulsado = !pulsado;
		}
		if (pulsado)
			Time.timeScale = 0;
		else {
			Time.timeScale = 1;
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (new Vector3 (velRotacion, velRotacion, velRotacion));
		MoverElCubo ();
		//Camibar el TimeScale al valor 0/1 con la tecla de espacio 
	}
	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 200, 30), "TimeScale: " + Time.timeScale.ToString ());
	}
	void MoverElCubo()
	{
		//Mueve el cubo en X y Z en un area determinada
		posXAct=transform.position.x+(Input.GetAxis("Horizontal")*velocidad*Time.timeScale);
		poszAct = transform.position.z + (Input.GetAxis ("Vertical") * velocidad*Time.timeScale);
		posActObj = new Vector3 (Mathf.Clamp (posXAct, minimoX, MaximoX), posActObj.y, Mathf.Clamp (poszAct,minimoZ,MaximoZ));
		transform.position = posActObj;
	}
}
