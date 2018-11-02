using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSwat : MonoBehaviour
{
    private bool startedSwat; 
    private float swatTimer;

    public float swatDelay;
    public float rotationSpeed;

    public Transform botSwing;
    public Transform topSwing;
    //private bool down = Input.GetKeyDown(KeyCode.Space);
/*  bool held = Input.GetKey(KeyCode.Space);
    bool up = Input.GetKeyUp(KeyCode.Space);
*/
    // Start is called before the first frame update
    void Start()
    {
        startedSwat = false;
        swatTimer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        swatTimer = swatTimer + Time.deltaTime;
        setSwinging();

        if(startedSwat){
            var step = rotationSpeed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, botSwing.rotation, step);

        }
            /*transform.Rotate(Vector3.right * rotationSpeed);
            */
            
    
    }

    void setSwinging(){
         if(Input.GetKeyDown(KeyCode.Space) && swatTimer >= swatDelay){
             startedSwat = true;
             Debug.Log("setSwinging");
         }
    }
}
