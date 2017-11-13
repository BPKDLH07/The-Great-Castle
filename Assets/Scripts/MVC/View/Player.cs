using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

	Vector3 startPos=new Vector3(0,0,0);
	Vector3 endPos=new Vector3(0,0,0);

	void NotAttack(){
		anim.SetBool("Attack",false);
	}

	void Attack(){
		anim.SetBool("Attack",true);
	}

	public void Movement(){
		Vector3.Slerp(startPos,endPos,1f);
	}

	void Jump(){

	}

}
