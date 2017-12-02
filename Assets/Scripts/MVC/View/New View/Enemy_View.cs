using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_View {
    public enum AdvancingFront {
        EnemyFront, EnemyLeft, EnemyRight, EnemyBack
    }
    public AdvancingFront enemyAdvancingFront;
    public bool enemyAdvance;
    Position_Model enemyPos = new Position_Model(0,0,0);
    public Vector3 enemyVector;
    public Quaternion enemyQuaternion;

    public void SetPos() {
        enemyVector = new Vector3(enemyPos.X, enemyPos.Y, enemyPos.Z);
    }

    //Posiblemente a este script lo cambie heredando tanto Enemy_View como Player_View de un Script que apodaré "Character_View"

    public void EnemyMoveFront() {   
        enemyPos.MoreZ();
        enemyVector.z = enemyVector.z + enemyPos.Z;
        enemyAdvancingFront = AdvancingFront.EnemyFront;
        enemyPos.Z = 0;
        enemyQuaternion = Quaternion.Euler(0, 0, 0);    
}

    public void EnemyMoveLeft()
    {
        enemyPos.LessX();
        enemyVector.x = enemyVector.x + enemyPos.X;
        enemyAdvancingFront = AdvancingFront.EnemyLeft;
        enemyPos.X = 0;
        enemyQuaternion = Quaternion.Euler(0, 0, 0);
    }
    public void EnemyMoveRight()
    {
        enemyPos.MoreX();
        enemyVector.x = enemyVector.x + enemyPos.X;
        enemyAdvancingFront = AdvancingFront.EnemyRight;
        enemyPos.X = 0;
        enemyQuaternion = Quaternion.Euler(0, 0, 0);
    }
    public void EnemyMoveBack()
    {
        enemyPos.LessZ();
        enemyVector.z = enemyVector.z + enemyPos.Z;
        enemyAdvancingFront = AdvancingFront.EnemyFront;
        enemyPos.Z = 0;
        enemyQuaternion = Quaternion.Euler(0, 180, 0);
    }
}
