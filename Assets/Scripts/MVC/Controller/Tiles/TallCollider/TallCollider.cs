using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallCollider : MonoBehaviour {
    [SerializeField]
    Player_Inputs playerInputs;
    Player_View colliderPlayer = new Player_View();

	// Use this for initialization
	void Start () {
        playerInputs = GameObject.Find("Panel_inputs").GetComponent<Player_Inputs>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            playerInputs.playerView.jumpingCondition = Player_View.JumpingCondition.tallerPlatform;
            Debug.Log("Esta Arriba");
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            playerInputs.FallDown();
            playerInputs.playerView.jumpingCondition = Player_View.JumpingCondition.canJump;
            Debug.Log("Salió");            
        }
    }
}
