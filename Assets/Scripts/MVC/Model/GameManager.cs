using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour {

    public bool isPlaying;
    public Time_Model theTime = new Time_Model(100f,0f);
    public Player_Model Player =new Player_Model(1,"Player");
    [SerializeField]
    RectTransform timeBar;

	// Use this for initialization
	void Start () {
        //timeBar = GameObject.Find("Image").GetComponent<RectTransform>();
        
	}

    // Update is called once per frame
    void Update()
    {   
        
        if(timeBar==null){
            timeBar = GameObject.Find("Image").GetComponent<RectTransform>();
        }
        


        if (isPlaying != false)
        {
            Debug.Log(Player.hp);
            if (Player.hp == 0)
            {
                GameOver();
            }

            if (theTime.TimeBar == 0f)
            {
                GameOver();
            }

            theTime.TimePoint();
            //Debug.Log(theTime.TimeScore);

            theTime.LessTimeBar();
            timeBar.localScale = new Vector3(theTime.TimeBar / 100f, 1, 1);
            //Debug.Log(theTime.TimeBar);

        }
    }

    public override string ToString()
    {
        return "Player Name:"+Player.name+ "Score: "+theTime.TimeScore;
    }

    void GameOver (){
		Player.hp = 1;
		SceneManager.LoadScene(3);
        isPlaying=false;        		

	}

	void PauseGame (){

		if (Time.timeScale == 1)
		Time.timeScale = 0;
		else
		Time.timeScale = 1;

	}



	}




