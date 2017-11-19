using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MahManager : MonoBehaviour {
	[SerializeField]
	Time_System timeSystem;

    Player_Model player = new Player_Model(1, "Pepito");

	void Start(){
        
	}

	void Update(){
		TheTimer();

        timeSystem.LessTimerBar();
        timeSystem.LessTimer();

        if (Input.GetKeyDown(KeyCode.Space)) {
            timeSystem.MoreTimer();
        }
    }

	void TheTimer(){
		Debug.Log(timeSystem.LessTime());
	}

}
