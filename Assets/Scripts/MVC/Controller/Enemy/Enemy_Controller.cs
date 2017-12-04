using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateStuff;

public class Enemy_Controller : MonoBehaviour {

    public Enemy_View enemy = new Enemy_View();
    public float trialTimer = 5f;

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

        if (switchState == true)
        {
            if (trialTimer <= 10f)
            {
                Mathf.Clamp(trialTimer, 0.1f, 5f);
                trialTimer = trialTimer - 0.2f;
                Debug.Log("No avances...");

            }
            if (trialTimer <= 0)
            {
                switch (enemy.theEnemyFront)
                {
                    case Enemy_View.CharacterViewFront.front:
                        enemy.MovementFront();
                        break;
                    case Enemy_View.CharacterViewFront.back:
                        enemy.MovementBack();
                        break;
                    case Enemy_View.CharacterViewFront.left:
                        enemy.MovementLeft();
                        break;
                    case Enemy_View.CharacterViewFront.right:
                        enemy.MovementRight();
                        break;
                }
                //enemy.EnemyMoveFront();
                Debug.Log("Avanzale");
                trialTimer = 5f;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            switchState = true;     
        }

    }



    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            switchState = false;
        }

    }


}
