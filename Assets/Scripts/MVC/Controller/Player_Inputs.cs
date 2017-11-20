using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Inputs : IBeginDragHandler, IDragHandler, IEndDragHandler
{

    //Aqui iran los inputs de eventos tactiles. Controles del jugador que accederán a los métodos del personaje (los que realizan las acciones) -gonzalo

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

        //Debug.Log(eventData.position);
    }

    public void OnEndDrag(PointerEventData eventData) //movimiento
    {
        Vector2 delta = eventData.delta;
        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            if (delta.x > 0)
                Debug.Log("Swipe Right");
            else if (delta.x < 0)
                Debug.Log("Swipe Left");
        }


    }

    }
