using UnityEngine;
using StateStuff;
using System;

public class FollowState : State<Enemy_Controller>
{
    private static FollowState _instance;

    private FollowState()               //constructor para establecer el estado
    {
        if(_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static FollowState Instance  //crear el estado y retornar su instancia
    {
        get
        {
            if(_instance == null)
            {
                new FollowState();
            }

            return _instance;
        }
    }

    public override void EnterState(Enemy_Controller _enemy)        //lo que pasa al entrar al estado
    {
        Debug.Log("Entering FollowState"); 
    }

    public override void ExitState(Enemy_Controller _enemy)         //lo que pasa al salir del estado
    {
        Debug.Log("Exiting FollowState");
    }

    public override void UpdateState(Enemy_Controller _enemy)       //lo que pasa durante el estado
    {
        if (_enemy.switchState)
        {
            _enemy.stateMachine.ChangeState(PatrolState.Instance);
        }

    }
}