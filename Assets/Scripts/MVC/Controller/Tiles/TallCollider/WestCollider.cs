using UnityEngine;

public class WestCollider : MonoBehaviour {

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
            _playerInputs.canMoveRight = false;
        }

    }

    void OnTriggerExit(Collider other)
    {


        if (other.tag == "Player")
        {
            _playerInputs.canMoveRight = true;
        }

    }

}