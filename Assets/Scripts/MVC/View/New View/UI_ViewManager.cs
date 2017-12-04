using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_ViewManager : MonoBehaviour {

    [SerializeField]
    Animator anim;
    [SerializeField]
    GameManager theGameManager;
    

    void Start() {
        anim=GameObject.Find("Panels").GetComponentInChildren<Animator>();
        theGameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
       
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
    

    //ScenesLoders
    public void NextScene(int index) {
        SceneManager.LoadScene(index);
        theGameManager.isPlaying=true;
        if(index==1||index==2){
            theGameManager.theTime.TimeBar=100f;
            theGameManager.theTime.TimeScore=0;
        }
    }



    

    



    

}
