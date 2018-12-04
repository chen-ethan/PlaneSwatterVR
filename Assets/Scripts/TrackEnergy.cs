using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackEnergy : MonoBehaviour {
	public bool rage;
	public float maxSize;
	public float growFactor;
	public float lockTime;
	private float minSize;
	private float lockTimer;
	private bool flip;
	private bool lockdown;


	// Use this for initialization
	void Start () {
		minSize = 0.0f;
		rage = false;
		lockdown = false;
		
	}
	

	void Update () {
		if(lockdown){
			lockTimer -= Time.deltaTime;
			if(lockTimer < 0){
				lockdown = false;
			}
		}

		if ((!Input.GetKey("space") || lockdown) && transform.localScale.y > minSize){
			transform.localScale -= new Vector3(0,growFactor,0);
			rage = false;
		}
		else{
			if(transform.localScale.y <= minSize){
				transform.localScale = new Vector3(transform.localScale.x,0,transform.localScale.z);
				if(!lockdown){
					rage = false;
				}
			}
			if((transform.localScale.y <= maxSize) && Input.GetKey("space")){
				transform.localScale += new Vector3(0,growFactor,0);
				if(!lockdown){
					rage = true;
				}
			}
			if(transform.localScale.y >= maxSize){
				Debug.Log("max reached");
				lockdown = true;
				lockTimer = lockTime;
				rage = false;
			}
		}	
	}
}
