using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmColor : MonoBehaviour {
	public TrackEnergy te;
	public Renderer rend;
	public Color32 baseBrown;

	// Use this for initialization
	void Start () {
		
		baseBrown.r = 120;
		baseBrown.g = 60;        
        baseBrown.b = 18;         
        baseBrown.a = 255;  
        

		rend = GetComponent<Renderer>();
        rend.material.color = baseBrown;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (te.rage){
			//rend.material.shader = Shader.Find("_Color");
        	rend.material.color = Color.red;
		}
		else{
			//rend.material.shader = Shader.Find("_Color");
        	rend.material.color = baseBrown;
		}
		
	}
}
