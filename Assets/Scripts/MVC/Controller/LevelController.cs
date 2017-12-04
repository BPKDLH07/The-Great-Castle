using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    [SerializeField]
    GameObject[] objects = new GameObject[4];



	// Use this for initialization
	void Start () {
        objects[0] = GameObject.Find("IniModuDownLeft(Clone)");
        objects[1] = GameObject.Find("ModuUpLeft(Clone)");
        objects[2] = GameObject.Find("EndModuUpRight(Clone)");
        objects[3] = GameObject.Find("ModuDownRight(Clone)");

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Destroy(objects[0]);
            Destroy(objects[1]);
            Destroy(objects[2]);
            Destroy(objects[3]);
        }
    }

}
