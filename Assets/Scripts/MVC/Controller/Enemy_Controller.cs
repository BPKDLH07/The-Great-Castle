using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateStuff;

public class Enemy_Controller : MonoBehaviour {

    public Enemy_View enemy = new Enemy_View();
    public float enemyTimer = 5f;

    public bool switchState = false;

    public StateMachine<Enemy_Controller> stateMachine {get; set;}  


private void Start()
    {
        stateMachine = new StateMachine<Enemy_Controller>(this);        
        stateMachine.ChangeState(IdleState.Instance);                 //establece la instancia existente del estado

        enemy.SetPos();
        enemy.charaVector = this.gameObject.transform.position;
        enemy.theEnemyFront = Enemy_View.CharacterViewFront.front;

    }

    private void Update()
    {

        this.gameObject.transform.position = enemy.charaVector;


        stateMachine.Update();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            switchState = !switchState;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            switchState = !switchState;
        }

    }


}
