using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class GunShoot : MonoBehaviour {

	public float fireRate = 0.25f;										
	public float weaponRange = 200f;
	bool recargando = false;

	public Transform gunEnd;
	public ParticleSystem muzzleFlash;
	public ParticleSystem cartridgeEjection;
	public Light fogonazo;
	public GameObject hole;

	private float nextFire;			
	public int municion;
	public int municionAcumulada;
	public int municionMaxima;
	private Animator anim;


	void Start () 
	{
		anim = GetComponent<Animator> ();
		fogonazo.enabled = false;
		GameObject.Find ("Cameras").SendMessage ("Iniciar");
	}

	void Update () 
	{
		if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
			if (municion != 0) {
				municion--;
				StartCoroutine (Fogonazo ());
				nextFire = Time.time + fireRate;
				muzzleFlash.Play ();
				muzzleFlash.GetComponent<AudioSource> ().Play ();
				cartridgeEjection.Play ();
				StartCoroutine (Casquillo ());
				anim.SetTrigger ("Fire");

				Vector3 rayOrigin = gunEnd.position;
				RaycastHit hit;
				if (Physics.Raycast (rayOrigin, gunEnd.forward, out hit, weaponRange)) {
					HandleHit (hit);
				}
			} else {
				if(!recargando)
				StartCoroutine ("Recarga");
			}
		} 

	}
	IEnumerator Recarga()
	{
		recargando = true;
		anim.SetTrigger ("Reload");	
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (1);
		if (municionAcumulada > 0) {
			

			if (municionAcumulada >= municionMaxima) {
				municion = municionMaxima;
				municionAcumulada -= municionMaxima;
			} else {
				municion = municionAcumulada;
			}
			recargando = false;
		}


	}
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2, Screen.height - 20, 200, 200), municion + "/" + municionAcumulada);
	}
	IEnumerator Casquillo()
	{
		yield return new WaitForSeconds (0.9f);
		cartridgeEjection.GetComponent<AudioSource> ().Play ();
	}
	IEnumerator Fogonazo()
	{
		fogonazo.enabled = true;
		yield return new WaitForSeconds (0.25f);
		fogonazo.enabled = false;
	}
	void HandleHit(RaycastHit hit)
	{
		hacerAgujero (hit, hole);
		if (hit.collider.tag == "enemigo") {
		
			hit.collider.SendMessage ("Herir");
		}
	}

	void hacerAgujero(RaycastHit hit, GameObject prefab)
	{
		GameObject spawnedDecal = GameObject.Instantiate(prefab, hit.point, Quaternion.LookRotation(hit.normal));
		spawnedDecal.transform.SetParent(hit.collider.transform);
	}
	void Ammo()
	{
		municionAcumulada += 50;
	}
}