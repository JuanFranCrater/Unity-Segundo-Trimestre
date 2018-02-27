using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class GunShoot : MonoBehaviour {

	public float fireRate = 0.25f;										
	public float weaponRange = 200f;										

	public Transform gunEnd;
	public ParticleSystem muzzleFlash;
	public ParticleSystem cartridgeEjection;
	public Light fogonazo;
	public GameObject hole;

	private float nextFire;												
	private Animator anim;

	void Start () 
	{
		anim = GetComponent<Animator> ();
		fogonazo.enabled = false;
	}

	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && Time.time > nextFire) 
		{
			StartCoroutine (Fogonazo ());
			Debug.Log ("Shoot");
			nextFire = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			anim.SetTrigger ("Fire");

			Vector3 rayOrigin = gunEnd.position;
			RaycastHit hit;
			if (Physics.Raycast(rayOrigin, gunEnd.forward, out hit, weaponRange))
			{
				HandleHit(hit);
			}
		}
		Debug.DrawRay (gunEnd.position, gunEnd.forward);
	}
	IEnumerator Fogonazo()
	{
		fogonazo.enabled = true;
		yield return new WaitForSeconds (0.25f);
		fogonazo.enabled = false;
	}
	void HandleHit(RaycastHit hit)
	{
		SpawnDecal (hit, hole);
	}

	void SpawnDecal(RaycastHit hit, GameObject prefab)
	{
		GameObject spawnedDecal = GameObject.Instantiate(prefab, hit.point, Quaternion.LookRotation(hit.normal));
		spawnedDecal.transform.SetParent(hit.collider.transform);
	}
}