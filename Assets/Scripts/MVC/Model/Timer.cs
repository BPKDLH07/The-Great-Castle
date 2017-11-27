using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float timeLeft = 10f;
    int timeScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeScore = (int)timeLeft;
        DecreaseTime();
        IncreaseTime();
        Debug.Log(timeScore);
    }


    //baja el tiempo constantemente (funcion independiente)
    void DecreaseTime()
    {
        timeLeft -= Time.deltaTime;
       
    }

    //agreaga tiempo al contador (debe ocurrir cuando acabas un nivel [collider?])
    void IncreaseTime()
    {
        //input es temporal para testear
        if (Input.GetKeyDown(KeyCode.T))
        {
            timeLeft = timeLeft + 10f;
            Debug.Log("time added");
            

        }


    }


}
