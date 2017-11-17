using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialScript2 : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {		
		SecondMethod();
	}

	void SecondMethod(){
			if(Input.GetKey(KeyCode.W)){
				transform.Translate(new Vector3(0,0,20f)*Time.deltaTime);				
			}
			if(Input.GetKey(KeyCode.S)){
				transform.Translate(new Vector3(0,0,-20f)*Time.deltaTime);				
			}
			if(Input.GetKey(KeyCode.A)){
				transform.Translate(new Vector3(-20f,0,0)*Time.deltaTime);				
			}
			if(Input.GetKey(KeyCode.D)){
				transform.Translate(new Vector3(20f,0,0)*Time.deltaTime);	
			}
	}
}
