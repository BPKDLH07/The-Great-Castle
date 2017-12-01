using UnityEngine;
using StateStuff;
using System;

public class PatrolState : State<Enemy_Controller>
{
    private static PatrolState _instance;

    private PatrolState()               //constructor para establecer el estado
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static PatrolState Instance  //crear el estado y retornar su instancia
    {
        get
        {
            if (_instance == null)
            {
                new PatrolState();
            }

            return _instance;
        }
    }

    public override void EnterState(Enemy_Controller _enemy)        //lo que pasa al entrar al estado
    {
        Debug.Log("Entering PatrolState");
    }

    public override void ExitState(Enemy_Controller _enemy)         //lo que pasa al salir del estado
    {
        Debug.Log("Exiting PatrolState");
    }

    public override void UpdateState(Enemy_Controller _enemy)       //lo que pasa durante el estado
    {
        if (!_enemy.switchState)
        {
            _enemy.stateMachine.ChangeState(FollowState.Instance);
        }

    }
}