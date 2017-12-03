using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_View: Character_View {
    public CharacterViewFront theEnemyFront;
    public bool enemyAdvance;

    public override void SetPos()
    {
        base.SetPos();
        theEnemyFront = CharacterViewFront.front;
    }

    public override void MovementFront()
    {
        base.MovementFront();
        theEnemyFront = CharacterViewFront.front;
    }

    public override void MovementBack()
    {
        base.MovementBack();
        theEnemyFront = CharacterViewFront.back;
    }

    public override void MovementLeft()
    {
        base.MovementLeft();
        theEnemyFront = CharacterViewFront.left;
    }

    public override void MovementRight()
    {
        base.MovementRight();
        theEnemyFront = CharacterViewFront.right;
    }


}
