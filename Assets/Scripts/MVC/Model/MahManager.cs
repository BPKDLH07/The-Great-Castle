using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MahManager : MonoBehaviour {
	[SerializeField]
	Time_System timeSystem;

	void Start(){
	}

	void Update(){
		TheTimer();
	}

	void TheTimer(){
		Debug.Log(timeSystem.LessTime());
	}

}
