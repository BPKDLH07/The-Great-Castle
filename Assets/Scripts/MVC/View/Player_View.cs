using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_View: Character_View {

    public CharacterViewFront thePlayerFront;
    public JumpingCondition jumpingCondition;   

    public override void SetPos()
    {
        base.SetPos();
        thePlayerFront = CharacterViewFront.front;
        jumpingCondition = JumpingCondition.canJump;
    }

    public override void MovementFront() {
        base.MovementFront();
        thePlayerFront = CharacterViewFront.front;
        charaRot = Quaternion.Euler(0, 0, 0);
    }

    public override void MovementBack()
    {
        base.MovementBack();
        thePlayerFront = CharacterViewFront.back;
        charaRot = Quaternion.Euler(0, 180, 0);
    }

    public override void MovementLeft()
    {
        base.MovementLeft();
        thePlayerFront = CharacterViewFront.left;
        charaRot = Quaternion.Euler(0, -90, 0);
    }

    public override void MovementRight()
    {
        base.MovementRight();
        thePlayerFront = CharacterViewFront.right;
        charaRot = Quaternion.Euler(0, 90, 0);
    }

    public override void MovementJump()
    {
        base.MovementJump();
        switch (thePlayerFront) {
            case CharacterViewFront.front:
                MovementFront();
                break;
            case CharacterViewFront.back:
                MovementBack();
                break;
            case CharacterViewFront.left:
                MovementLeft();
                break;
            case CharacterViewFront.right:
                MovementRight();
                break;
        } 
    }

    public override void Falling()
    {
        base.Falling();
    }
}
