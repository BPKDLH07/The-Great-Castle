﻿using UnityEngine;

public class EastCollider : MonoBehaviour {

    Player_Inputs _playerInputs;

    // Use this for initialization
    void Start()
    {

        _playerInputs = GameObject.Find("Panel_inputs").GetComponent<Player_Inputs>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Player")
        {
            _playerInputs.canMoveLeft = false;
        }

    }

    void OnTriggerExit(Collider other)
    {


        if (other.tag == "Player")
        {
            _playerInputs.canMoveLeft = true;
        }

    }

}