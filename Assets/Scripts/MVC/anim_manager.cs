using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_manager : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

public void NotAttack()
{
	anim.SetBool("Attack", false);

	
}

public void Attack(){

	anim.SetBool("Attack", true);


}

}
