using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter(Collider col){
        Debug.Log("got hit");
        if(col.gameObject.CompareTag("Arm")&&OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)){
            Destroy(this.gameObject);
        }

    }
}
