using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_System: MonoBehaviour {
	
    //Aqui ira el sistema de tiempo, que es constante durante el juego y funciona de manera independiente. -gonzalo


	My_Time myTimeScore = new My_Time(0);
    My_Time myTimer = new My_Time(100);

    public RectTransform timerBar;
    
    //Score de Timer
    public float LessTime(){
		myTimeScore.Decrease(Time.deltaTime);
		return myTimeScore.Timer;
	}

    //Barra de Timer
    public int LessTimer() {
        return myTimer.Timer=myTimer.Timer-1;
    }

    public void LessTimerBar() {
        timerBar.localScale = new Vector3(myTimer.Timer / 100f, 1, 1);
        myTimer.Timer = Mathf.Clamp(myTimer.Timer, 0, 100);
    }

    public int MoreTimer() {
        return myTimer.Timer = myTimer.Timer + 50;
    }
	
}
