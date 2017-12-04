using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Inputs : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    //Aqui iran los inputs de eventos tactiles. Controles del jugador que accederán a los métodos del personaje (los que realizan las acciones) -gonzalo

    public Player_View playerView = new Player_View();
    public anim_manager animManager;
    public GameObject thePlayer;
    public GameObject PlayerChild;
    [SerializeField] float jumpTimer = 1f;
    public bool canMoveUp = true;
    public bool canMoveDown = true;
    public bool canMoveLeft = true;
    public bool canMoveRight = true;

    void Start()
    {
        playerView.SetPos();
        playerView.charaVector = thePlayer.transform.position;

    }

  
    void Update()
    {
        thePlayer.gameObject.transform.position = playerView.charaVector;        
        PlayerChild.transform.rotation=playerView.charaRot;

        if (jumpTimer <= 5 && playerView.jumpingCondition == Player_View.JumpingCondition.cantJump)
        {
            Mathf.Clamp(jumpTimer, 0, 2f);
            jumpTimer = jumpTimer - 0.2f;

        }
        if (jumpTimer <= 0 && playerView.jumpingCondition == Player_View.JumpingCondition.cantJump)
        {
            FallDown();
            playerView.jumpingCondition = Player_View.JumpingCondition.canJump;

        }
    }




    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

    
    }

    public void OnEndDrag(PointerEventData eventData) 
    {
        Vector2 delta = eventData.delta;


        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            if (delta.x > 0 & canMoveRight == true){
                playerView.MovementRight();                
                //Debug.Log("swipe right");

            }
            else if (delta.x < 0 & canMoveLeft == true){
                playerView.MovementLeft();
               // Debug.Log("swipe left");

            }
        }

        if (Mathf.Abs(delta.y) > Mathf.Abs(delta.x))
        {

            if (delta.y > 0 & canMoveUp == true){
                playerView.MovementFront();
                //Debug.Log("swipe up");

            }
            else if (delta.y < 0 & canMoveDown == true){
                playerView.MovementBack();
                //Debug.Log("swipe down");

            }
        }       

    }

    public void attack(){

       animManager.Attack();

    }

    //Toque por Necesidad el Controlador agregando el método de Jump al Input. -Daniel    
    public void Jumping()
    {
        if (playerView.jumpingCondition == Player_View.JumpingCondition.canJump)
        {
            playerView.MovementJump();
            jumpTimer = 2f;
            playerView.jumpingCondition = Player_View.JumpingCondition.cantJump;
        }
    }

    public void FallDown()
    {
        playerView.Falling();
    }

}
