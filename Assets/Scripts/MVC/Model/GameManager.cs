using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager {

public Timer Timor = new Timer();
public Player_Model Player =new Player_Model(1,"Nombre");

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	if(Player.HP==0){
		GameOver();
	}

	if(Timor.timeLeft ==0){
		GameOver();
	}

	if (Input.GetKeyDown(KeyCode.Escape)){
		PauseGame();
	//input temporal
	}



	}

	void GameOver (){
	
		Debug.Log ("Game Over");
		

	}

	void PauseGame (){

		if (Time.timeScale == 1)
		Time.timeScale = 0;
		else
		Time.timeScale = 1;

	}



	}




