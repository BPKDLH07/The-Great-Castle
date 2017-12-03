using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character_View {
    public enum CharacterViewFront {
        front, back, left, right
    }
    public enum JumpingCondition {
        canJump, cantJump, tallerPlatform
    }
    public Position_Model charaPos = new Position_Model(0, 0, 0);

    public Vector3 charaVector;
    public Quaternion charaRot;

    public virtual void SetPos() {
        charaVector = new Vector3(charaPos.X, charaPos.Y, charaPos.Z);
    }

    public virtual void MovementFront() {
        charaPos.MoreZ();
        charaVector.z = charaVector.z + charaPos.Z;
        charaPos.Z = 0;
        Debug.Log("Aquí si funciono");
    }

    public virtual void MovementBack()
    {
        charaPos.LessZ();
        charaVector.z = charaVector.z + charaPos.Z;
        charaPos.Z = 0;
        Debug.Log("Aquí si funciono");
    }

    public virtual void MovementLeft()
    {
        charaPos.LessX();
        charaVector.x = charaVector.x + charaPos.X;
        charaPos.X = 0;
        Debug.Log("Aquí si funciono");
    }

    public virtual void MovementRight()
    {
        charaPos.MoreX();
        charaVector.x = charaVector.x + charaPos.X;
        charaPos.X = 0;
        Debug.Log("Aquí si funciono");
    }

    public virtual void MovementJump() {
        charaPos.MoreY();
        charaVector.y = charaVector.y + charaPos.Y;
        charaPos.Y = 0;
        Debug.Log("Aquí si funciono");
    }

    public virtual void Falling() {
        charaPos.LessY();
        charaVector.y = charaVector.y + charaPos.Y;
        charaPos.Y = 0;
        Debug.Log("Aquí si funciono");
    }







}
