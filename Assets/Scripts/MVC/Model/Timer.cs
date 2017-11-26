using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float timeLeft = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DecreaseTime();
        IncreaseTime();
	}


    //baja el tiempo constantemente (funcion independiente)
    void DecreaseTime()
    {
        timeLeft -= Time.deltaTime;
       
          if (timeLeft <= 0)
        {
            GameOver();
        }
    }

    //agreaga tiempo al contador (debe ocurrir cuando acabas un nivel [collider?])
    void IncreaseTime()
    {
        //input es temporal para testear
        if (Input.GetKeyDown(KeyCode.T))
        {
            timeLeft = timeLeft + 10.0f;
            Debug.Log("time added");

        }


    }


    //simulacion temporal de game over (heredar del game manager)
    void GameOver()
    {
        Debug.Log("game over");

    }
}
