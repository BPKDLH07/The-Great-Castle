using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_View {
	public Animator pAnim;
	public Vector3 myVector;
	Position_Model thePosition=new Position_Model(0,0,0);

	public void SetPos(){
		myVector=new Vector3(thePosition.X,thePosition.Y,thePosition.Z);
	}
	
	public void Attack(){
		pAnim.SetBool("Attack",true);
	}

	public void NotAttack(){
		pAnim.SetBool("Attack",false);
	}

	public void MovementFront(){
		thePosition.MoreZ();
        myVector.z=myVector.z+thePosition.Z;
        thePosition.Z = 0;
        //Debug.Log(myVector);
	}

	public void MovementBack(){
		thePosition.LessZ();
        myVector.z = myVector.z + thePosition.Z;
        thePosition.Z = 0;
        //Debug.Log(myVector);
    }

	public void MovementLeft(){
		thePosition.LessX();
        myVector.x = myVector.x + thePosition.X;
        thePosition.X = 0;
       // Debug.Log(myVector);
    }

	public void MovementRight(){
		thePosition.MoreX();
        myVector.x = myVector.x + thePosition.X;
        thePosition.X = 0;
        //Debug.Log(myVector);
    }

	public void NotMovement(){
		thePosition.X=0;
		thePosition.Y=0;
		thePosition.Z=0;
	}

	public void Falling(){
		thePosition.LessY();
	}
	

}
