using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTimeScale : MonoBehaviour {
	Vector3 posIniObj=new Vector3(0f,0.5f,0f);
	Vector3 posActObj;
	float posXAct;
	float posYAct;
	float poszAct;
	float velocidad = 0.5f;
	float minimoX = -4.5f;
	float MaximoX = 4.5f;
	float minimoZ= -4.5F;
	float MaximoZ= 4.5f;

	void Start()
	{
		posActObj = posIniObj;
	}
	void FixedUpdate()
	{
		posXAct=transform.position.x+(Input.GetAxis("Horizontal")*velocidad*Time.timeScale);
		poszAct = transform.position.z + (Input.GetAxis ("Vertical") * velocidad*Time.timeScale);
		posActObj = new Vector3 (Mathf.Clamp (posXAct, minimoX, MaximoX), posActObj.y, Mathf.Clamp (poszAct,minimoZ,MaximoZ));
		transform.position = posActObj;
			
	}
}
