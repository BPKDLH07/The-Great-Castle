using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialScript : MonoBehaviour {
	Animator anim;

	[SerializeField]
	GameObject mahPlayer;

	Vector3 currentPos;	
	Vector3 newPos;


	void Start(){
		anim=GetComponent<Animator>();
	}

	void Update(){		
		FirstMovement();
	}

	void FirstMovement(){
		anim.SetBool("Advancing",false);
		if(Input.GetKeyDown(KeyCode.Space)){
			//anim.SetTrigger("Adgancing");
			anim.SetBool("Advancing",true);		
		}
	}
	public void NewPosition(){
		mahPlayer.transform.Translate (new Vector3(0,0,2));
	}
	
}
