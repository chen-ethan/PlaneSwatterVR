using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnersController : MonoBehaviour {

	private static float spawnerTimer;
	private int numPlanesSpawned;

	int children; 
	//public int numberOfSpawns;
	public float delay;
	void Start () {
		spawnerTimer = 0.0f;
		numPlanesSpawned = 0;
		children = transform.childCount;
	}
	
	// Update is called once per frame
	void Update () {
		spawnerTimer += Time.deltaTime;
		
		if(spawnerTimer >= delay){
			spawnRandomPlane();
		}
	}

	void spawnRandomPlane(){
		int plane = (int)Random.Range(0,children);
		Debug.Log("plane #" + plane);
		spawnPlane sp = (spawnPlane)transform.GetChild(plane).gameObject.GetComponent(typeof(spawnPlane));
		sp.spawn();
		spawnerTimer = 0.0f;
		numPlanesSpawned++;
	}
}
