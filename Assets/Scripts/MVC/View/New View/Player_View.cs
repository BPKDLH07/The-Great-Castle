using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_View {

	public enum PlayerViewFront{
		front, back, left, right
	}
    public enum JumpingCondition
    {
        canJump, cantJump, tallerPlatform
    }

	Position_Model thePosition=new Position_Model(0,0,0);

	public PlayerViewFront thePlayerFront;
    public JumpingCondition jumpingCondition;

    public Vector3 myVector;
    public Quaternion myQuaternion;


    public void SetPos(){
		myVector=new Vector3(thePosition.X,thePosition.Y,thePosition.Z);
		thePlayerFront=PlayerViewFront.front;
        jumpingCondition = JumpingCondition.canJump;	
	}	

	public void MovementFront(){
		thePosition.MoreZ();
        myVector.z=myVector.z+thePosition.Z;
		thePlayerFront=PlayerViewFront.front;
        thePosition.Z = 0;
		myQuaternion=Quaternion.Euler(0,0,0);
        //Debug.Log(myVector);
	}

	public void MovementBack(){
		thePosition.LessZ();
        myVector.z = myVector.z + thePosition.Z;
        thePosition.Z = 0;
		thePlayerFront=PlayerViewFront.back;
		myQuaternion=Quaternion.Euler(0,180,0);
        //Debug.Log(myVector);
    }

	public void MovementLeft(){
		thePosition.LessX();
        myVector.x = myVector.x + thePosition.X;
        thePosition.X = 0;
		thePlayerFront=PlayerViewFront.left;
		myQuaternion=Quaternion.Euler(0,-90,0);
       // Debug.Log(myVector);
    }

	public void MovementRight(){
		thePosition.MoreX();
        myVector.x = myVector.x + thePosition.X;
        thePosition.X = 0;
		thePlayerFront=PlayerViewFront.right;
		myQuaternion=Quaternion.Euler(0,90,0);
        //Debug.Log(myVector);
    }

	public void MovementJump(){
		thePosition.MoreY();
		myVector.y = myVector.y + thePosition.Y;
        thePosition.Y = 0;

		switch(thePlayerFront){
			case PlayerViewFront.front:
				MovementFront();
				break;
			case PlayerViewFront.back:
				MovementBack();
				break;
			case PlayerViewFront.left:
				MovementLeft();
				break;
			case PlayerViewFront.right:
				MovementRight();
				break;
		}
	}

	public void NotMovement(){
		thePosition.X=0;
		thePosition.Y=0;
		thePosition.Z=0;
	}

	public void Falling(){
		thePosition.LessY();
        myVector.y = myVector.y + thePosition.Y;
        thePosition.Y = 0;
	}
	

}
