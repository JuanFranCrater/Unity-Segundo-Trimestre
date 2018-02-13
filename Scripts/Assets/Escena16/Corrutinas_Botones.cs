using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas_Botones : MonoBehaviour {

	public Light _luz;

	// Use this for initialization
	void Start () {
		

	}
	
	public void InitParpadeo()
	{
		StartCoroutine ("Parpadeo");
	}
	public void InitColor ()
	{
		StartCoroutine ("ControlColor");
	}

	public void StopParpadeo()
	{
		StopCoroutine ("Parpadeo");
	}
	public void StopColor ()
	{
		StopCoroutine ("ControlColor");

	}
	// Corrutinas

	IEnumerator Parpadeo()
	{
		int nVeces = 20;
		while(true)
		{
			for(int i=0;i<nVeces;i++)
			{
				_luz.enabled = !_luz.enabled;
				yield return new WaitForSeconds (Random.Range(0.1f,0.5f));
			}
			_luz.enabled = Random.Range (0, 2) == 0?true:false;
			yield return new WaitForSeconds (3);
		}
	}

	IEnumerator ControlColor()
	{
		while (true) {
			_luz.color = Color.Lerp (Color.red, Color.yellow, Mathf.PingPong (Time.time / 2, 1));
			yield return null;
		}
	}
}
