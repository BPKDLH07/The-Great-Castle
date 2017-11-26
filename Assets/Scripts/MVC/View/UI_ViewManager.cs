using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_ViewManager : MonoBehaviour {

    Animator anim;

    [SerializeField]
    InputField playerName;

    [SerializeField]
    Text txtLog;

    void Start() {
        //anim = GetComponentInChildren<Animator>();
        anim = GetComponentInChildren<Animator>();
        txtLog.text = "";
    }

    //Setting Button
    public void HereSettingButton()
    {
        anim.SetTrigger("SettingsDown");
    }
    public void ExitSettingButton()
    {
        anim.SetTrigger("SettingsUp");
    }

    //Score Button
    public void HereScoreButton()
    {
        anim.SetTrigger("ScoreUp");
    }   

    public void ExitScoreButton()
    {
        anim.SetTrigger("ScoreDown");
    }

    //Score Name
    public void HereScoreNameButton()
    {
        anim.SetTrigger("NameEnter");
    }

    public void ExitScoreNameButton() {
        anim.SetTrigger("NameExit");
        PlayerInfo();
    }

    //ScenesLoders
    public void NextScene(int index) {
        SceneManager.LoadScene(index);
    }

    public void PlayerInfo() {
        Player_Model myPlayer = new Player_Model(1, playerName.text);
        TXTLog(myPlayer.ToString());
    }

    public void TXTLog(string myText) {
        txtLog.text += myText + "\n";
    }



    

}
