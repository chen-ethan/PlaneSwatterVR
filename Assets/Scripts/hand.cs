using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {

    private GameObject hitObj;
    public GameObject playerRig;
    public GameObject ballPrefab;
    private GameObject ball;

	// Use this for initialization
	void Start ()
    {
        ball = null;
    }
	
	// Update is called once per frame
	void Update () {
		if (playerRig.GetComponent<VRRaycaster>().thingHit)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                ball = Instantiate(ballPrefab, gameObject.transform);
                ball.GetComponent<Rigidbody>().isKinematic = true;
                ball.transform.parent = gameObject.transform;
            }
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger) && (ball != null))
        {
            ball.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * 9;
            ball.GetComponent<Rigidbody>().isKinematic = false;
            ball.transform.parent = null;
            ball.GetComponent<BallScript>().kill();
        }
    }
}
