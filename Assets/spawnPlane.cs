using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlane : MonoBehaviour {


	private static float timer;
	public float spawnDelay;
	public Rigidbody plane; 
	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if(timer >= spawnDelay){
			//spawn plane
			Rigidbody clone;
			clone = Instantiate(plane,this.transform.position,this.transform.rotation);


			timer = 0.0f;

		}
	}
}
