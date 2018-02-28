using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int numEnemigos=5;
	public GameObject enemigo;
	public Transform[] spawnPoints;  
	int spawnPointIndex =0;
	void Start () {
		StartCoroutine ("SpawnEnemigos",numEnemigos);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("enemigo").Length == 0) {
			StartCoroutine ("SpawnEnemigos",numEnemigos);
			numEnemigos++;
		}
	}
	IEnumerator SpawnEnemigos(int numEnemigos)
	{
		
		for (int i = 0; i<(int)numEnemigos;i++)
		{
			spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (enemigo, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			yield return new WaitForSeconds (0.75f);
		}

	}
}
