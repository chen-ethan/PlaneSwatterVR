using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbagePlane : MonoBehaviour {
	public HandSwat HS;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider col){
        if(col.gameObject.CompareTag("Plane")/*  && OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)*/){
            Destroy(col.gameObject);
            HS.score -=1;
            Debug.Log("-1 SCORE: " + HS.score);
        }

    }

}
