using UnityEngine;
using StateStuff;
using System;

public class AttackState : State<Enemy_Controller>
{
    private static AttackState _instance;

    Enemy_Controller enemyControl = new Enemy_Controller();


    private AttackState()               //constructor para establecer el estado
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static AttackState Instance  //crear el estado y retornar su instancia
    {
        get
        {
            if (_instance == null)
            {
                new AttackState();
            }

            return _instance;
        }
    }

    public override void EnterState(Enemy_Controller _enemy)        //lo que pasa al entrar al estado
    {
        Debug.Log("Entering AttackState");


    }

    public override void ExitState(Enemy_Controller _enemy)         //lo que pasa al salir del estado
    {
        Debug.Log("Exiting AttackState");
    }

    public override void UpdateState(Enemy_Controller _enemy)       //lo que pasa durante el estado
    {
        enemyControl.enemy.SetPos();


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           enemyControl.enemy.theEnemyFront = Enemy_View.CharacterViewFront.front;
           enemyControl.enemy.MovementFront();
        }



        if (!_enemy.switchState)
        {
            _enemy.stateMachine.ChangeState(IdleState.Instance);
        }

    }
}