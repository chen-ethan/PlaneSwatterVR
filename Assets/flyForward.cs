using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyForward : MonoBehaviour {

	// Use this for initialization
	public float speed;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.right * Time.deltaTime * speed;
	}
}
