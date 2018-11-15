using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TopColliderScript : MonoBehaviour {

    public GameObject box;

    // Use this for initialization
    void Start () {
        box.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        box.SetActive(true);
    }
}
