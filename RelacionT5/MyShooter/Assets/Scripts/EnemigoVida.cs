using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVida : MonoBehaviour {

	public int vida =4;
	public Material naranja;
	public GameObject ammo;
	public GameObject medic;
	float moveSpeed = 1.5f; 
	float rotationSpeed = 1.5f; 

	void Update () {
		switch (vida)
		{
		case 0:
			GameObject.FindGameObjectWithTag ("controlador").SendMessage ("MasPuntos");
			if (Random.Range (0, 5) == 0) {
				Instantiate (ammo);
			} else if (Random.Range (0, 5) == 0) {
				Instantiate (medic);
			}
			Destroy (gameObject);
			break;
		case 1:
			GetComponent<Renderer> ().material.color = Color.red;
			break;
		case 2:
			GetComponent<Renderer> ().material = naranja;
			break;
		case 3:
			GetComponent<Renderer> ().material.color = Color.yellow;
			break;
		case 4:
			GetComponent<Renderer> ().material.color = Color.green;
			break;
		}

	}
	void FixedUpdate()
	{
		if (GameObject.Find ("Tirador") != null) {
			GetComponent<Transform> ().rotation = Quaternion.Slerp (GetComponent<Transform> ().rotation,
				Quaternion.LookRotation (GameObject.Find ("Tirador").GetComponent<Transform> ().position - GetComponent<Transform> ().position), rotationSpeed * Time.deltaTime);
			GetComponent<Transform> ().position += GetComponent<Transform> ().forward * moveSpeed * Time.deltaTime;
		}
	}
	void Herir()
	{
		vida--;
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Tirador") {
			collision.gameObject.SendMessage ("Herir");
			StartCoroutine (Carga ());

		}
	}
	IEnumerator Carga()
	{
		moveSpeed = 0;
		yield return new WaitForSeconds (2f);
		moveSpeed =  1.5f;

	}

}
