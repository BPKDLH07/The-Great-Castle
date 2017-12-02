using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Log : MonoBehaviour {

	[SerializeField]
    InputField playerName;

    [SerializeField]
    Text txtLog;

	[SerializeField]
	Animator anim;

	// Use this for initialization
	void Start () {
		anim=GameObject.Find("Panels").GetComponentInChildren<Animator>();
		playerName=GameObject.Find("PlayerInputField").GetComponent<InputField>();
        txtLog=GameObject.Find("TextScore").GetComponent<Text>();
        txtLog.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerInfo() {
        Player_Model myPlayer = new Player_Model(1, playerName.text);
        TXTLog(myPlayer.ToString());
    }

	public void TXTLog(string myText) {
        txtLog.text += myText + "\n";
    }

    public void ExitSettingsButton() {
        anim.SetTrigger("SettingsUp");
    }

    public void ExitScoreButton() {
        anim.SetTrigger("ScoreDown");
    }

	public void ExitScoreNameButton() {
        anim.SetTrigger("NameExit");
        PlayerInfo();
    }

	
}
