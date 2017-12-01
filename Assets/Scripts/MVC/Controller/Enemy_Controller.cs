using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateStuff;

public class Enemy_Controller : MonoBehaviour {

    public bool switchState = false;

    public StateMachine<Enemy_Controller> stateMachine {get; set;}  


private void Start()
    {
        stateMachine = new StateMachine<Enemy_Controller>(this);        
        stateMachine.ChangeState(FollowState.Instance);                 //establece la instancia existente del estado
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))                    //input temporal para cambiar de estados (testeo)
        {
            switchState = !switchState;

        }

        stateMachine.Update();
    }

}
