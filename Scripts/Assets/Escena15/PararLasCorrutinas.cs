using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Asignado a algo, me da igual pa cuatro cosas que hay
public class PararLasCorrutinas : MonoBehaviour {

	bool ejecutar = true;
	int nSaludo = 1;

	void Start () {
		//StartCoroutine ("SaludaCadaSegundo");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			//StopCoroutine ("SaludaCadaSegundo");
			ejecutar=false;
		}
	}
		
	void OnEnable()
	{
		StartCoroutine(SaludaCadaSegundo("Hola a todos...", 1));
		StartCoroutine(SaludaCadaSegundo("Hola a casi todos...", 3));
		StartCoroutine(SaludaCadaSegundo("Hola a Eliseo...", 0.25f));
	}
	void OnDisable()
	{
		StopAllCoroutines ();
	}

	IEnumerator SaludaCadaSegundo(string mensaje,float tiempo)
	{
		while (true) {
			if(!ejecutar)
			{
				yield break;
			}
			Debug.Log (mensaje+". Mensaje numero "+nSaludo+" Tiempo: "+Time.time);
			nSaludo++;
			yield return new WaitForSeconds (tiempo);
		}
	}
}
