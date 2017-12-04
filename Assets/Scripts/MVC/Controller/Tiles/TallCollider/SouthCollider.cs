using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthCollider : MonoBehaviour {

    Player_Inputs _playerInputs;

	// Use this for initialization
	void Start () {

        _playerInputs = GameObject.Find("Panel_inputs").GetComponent<Player_Inputs>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Player")
        {
            _playerInputs.canMoveUp = false;
        }

    }

    void OnTriggerExit(Collider other)
    {


        if (other.tag == "Player")
        {
            _playerInputs.canMoveUp = true;
        }

    }

}
