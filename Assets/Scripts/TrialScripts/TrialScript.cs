using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialScript : MonoBehaviour {

    // Este controlador es solo uan prueba, el vedadero será un Manager creado por mi Compañero Gonzalo -Daniel
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
        FirstJumping();
	}

	void FirstMovement(){
		anim.SetBool("Advancing",false);
		if(Input.GetKeyDown(KeyCode.Space)){
			//anim.SetTrigger("Adgancing");
			anim.SetBool("Advancing",true);		
		}
	}

    void FirstJumping() {
        anim.SetBool("Jumping", false);
        if (Input.GetKeyDown(KeyCode.M)) {
            anim.SetBool("Jumping", true);
        }
    }

	public void NewPosition(){
		mahPlayer.transform.Translate (new Vector3(0,0,2));
	}

    public void NewPositionJump() {
        mahPlayer.transform.Translate(new Vector3(0, 2, 2));
    }	
}
