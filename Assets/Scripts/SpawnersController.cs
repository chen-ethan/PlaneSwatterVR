using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnersController : MonoBehaviour {

	private static float spawnerTimer;
	//public int numberOfSpawns;
	public float delay;
	void Start () {
		spawnerTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		spawnerTimer += Time.deltaTime;
		int children = transform.childCount;
		if(spawnerTimer >= delay){
			int plane = (int)Random.Range(0,children);
			Debug.Log("plane #" + plane);
			spawnerTimer = 0.0f;
		}
	}
}
