using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {

	int salud=10;
	public Text mensajeFin;
	void Start()
	{
		salud = 10;
	}
	void Herir()
	{
		if(salud!=0)
		salud--;
	}
	void Update()
	{
		if (salud == 0) {
			Destroy (GameObject.Find ("GunAim"));
			mensajeFin.enabled = true;
			GameObject.Find ("Cameras").SendMessage ("Morir");
			if (Input.GetKey (KeyCode.Escape)) {
				SceneManager.LoadScene ("Shooter");
			}
		}
	}
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2,  20, 200, 200), "Salud: " + salud);
	}
	void FixedUpdate () {
		if (salud != 0) {
			transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime * 2 * Input.GetAxis ("Vertical");
			transform.position = transform.position + Camera.main.transform.right * Time.deltaTime * 2 * Input.GetAxis ("Horizontal");
		}
	}
	void OnCollisionEnter(Collision collision)
	{
		if (salud != 0) {
			if (collision.gameObject.tag == "medic") {
				salud += 5;
				GameObject.Find ("MedicSound").GetComponent<AudioSource> ().Play ();
				Destroy (collision.gameObject);
			}
			if (collision.gameObject.tag == "ammo") {
				GameObject.Find ("GunShoot").SendMessage ("Ammo");
				GameObject.Find ("AmmoSound").GetComponent<AudioSource> ().Play ();
				Destroy (collision.gameObject);
			}
			if (collision.gameObject.tag == "enemigo") {
				GetComponent<AudioSource> ().Play ();
			}
		}
	}
}
