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
    


    void Start()
    {
        playerView.SetPos();
        playerView.myVector = thePlayer.transform.position;

    }

  
    void Update()
    {
        thePlayer.gameObject.transform.position = playerView.myVector;        
        PlayerChild.transform.rotation=playerView.myQuaternion;
                
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
            if (delta.x > 0){
                playerView.MovementRight();                
                Debug.Log("swipe right");

            }
            else if (delta.x < 0){
                playerView.MovementLeft();
                Debug.Log("swipe left");

            }
        }

        if (Mathf.Abs(delta.y) > Mathf.Abs(delta.x))
        {

            if (delta.y > 0){
                playerView.MovementFront();
                Debug.Log("swipe up");

            }
            else if (delta.y < 0){
                playerView.MovementBack();
                Debug.Log("swipe down");

            }
        }       

    }

    public void attack(){

       animManager.Attack();

    }

    //Toque por Necesidad el Controlador agregando el método de Jump al Input. -Daniel    
    public void Jumping(){
            playerView.MovementJump();           
     }

    public void FallDown() {
        playerView.Falling();
    }

    }
