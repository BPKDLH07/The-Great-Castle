using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialScript2 : MonoBehaviour {

	//Este segundo controlador de prueba no es definivo, solo está hecho para probar lo visual, Gonzalo hará el Manager Definitivo -Daniel
    
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

        if (Input.GetKey(KeyCode.K)) {
            transform.Translate(new Vector3(0, 20f, 20f)*Time.deltaTime);
        }
	}
}
