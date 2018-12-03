using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackEnergy : MonoBehaviour {
	public float maxSize;
	public float growFactor;
	private float minSize;
	private float timer;
	private bool flip;


	// Use this for initialization
	void Start () {
		timer = 0.0f;
		minSize = 0.2f;
		
	}
	

	void Update () {
		if (!Input.GetKey("space") && transform.localScale.y > minSize){
			transform.localScale -= new Vector3(0,growFactor,0);
		}
		else{
			if(transform.localScale.y < maxSize){
				transform.localScale += new Vector3(0,growFactor,0);
			}
		}	
	}
}
