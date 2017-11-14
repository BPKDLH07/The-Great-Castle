using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_System: MonoBehaviour {
	
    //Aqui ira el sistema de tiempo, que es constante durante el juego y funciona de manera independiente. -gonzalo
	My_Time myTime = new My_Time(40);

	public float LessTime(){
		myTime.Decrease(Time.deltaTime);
		return myTime.Timer;
	}
	
}
