using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownCollider : MonoBehaviour {

	[SerializeField]
	float fallDownTile;
	int theDelta;
	[SerializeField]
	bool withthePlayer;

	[SerializeField]
	bool startFalling;
	// Use this for initialization
	void Start () {
		withthePlayer=false;
		startFalling=false;
	}
	
	// Update is called once per frame
	void Update () {
		theDelta=(int)fallDownTile;
		if(startFalling==true){
			LessTimer();
			Debug.Log(theDelta);
		}
	}

	void LessTimer(){
		fallDownTile-=Time.deltaTime;
	}

	void OnTriggerEnter(Collider other){
		if(other.tag=="Player"){
			startFalling=true;			
			Debug.Log("Iniciando Proceso de caída");
		}
	}

	void OnTriggerStay(Collider other){
		if(other.tag=="Player"){
			withthePlayer=true;
		}
		if(theDelta<=0&& withthePlayer==false){
			Debug.Log("Plataforma cayó");
		} 
		else 
		if(theDelta<=0 && withthePlayer==true){
			Debug.Log("Plataforma se cayó con Player");
		}		
	}

	void OnTriggerExit(Collider other){
		if(other.tag=="Player"){
			withthePlayer=false;
			Debug.Log("Player ya no se caerá");
		}
	}
}
