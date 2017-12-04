using UnityEngine;
using StateStuff;

public class IdleState : State<Enemy_Controller>
{
    private static IdleState _instance;

    private IdleState()               //constructor para establecer el estado
    {
        if(_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static IdleState Instance  //crear el estado y retornar su instancia
    {
        get
        {
            if(_instance == null)
            {
                new IdleState();
            }

            return _instance;
        }
    }

    public override void EnterState(Enemy_Controller _enemy)        //lo que pasa al entrar al estado
    {
        Debug.Log("Entering IdleState"); 
    }

    public override void ExitState(Enemy_Controller _enemy)         //lo que pasa al salir del estado
    {
        Debug.Log("Exiting IdleState");
    }

    public override void UpdateState(Enemy_Controller _enemy)       //lo que pasa durante el estado
    {

        if (_enemy.switchState)
        {
            _enemy.stateMachine.ChangeState(AttackState.Instance);
        }

    }

   


}