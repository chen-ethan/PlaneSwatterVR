using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomColliderScript : MonoBehaviour {

    public float deleteTime;
    public GameObject scoreCount;
    private float startTime = 0.0f;

	// Use this for initialization
	void OnEnable()
    {
        startTime = Time.time;
        Debug.Log("starttime is:" + startTime);
	}


    // Update is called once per frame
    void Update () {
		if (Time.time - startTime > deleteTime)
        {
            gameObject.SetActive(false);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        scoreCount.GetComponent<ScoreKeeper>().updateScore();
        gameObject.SetActive(false);
    }
}
