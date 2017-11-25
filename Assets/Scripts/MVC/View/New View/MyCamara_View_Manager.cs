using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamara_View_Manager : MonoBehaviour {

	public Transform target;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.z, target.position.y);

        this.transform.rotation = Quaternion.Euler(45, -45, 0);

    }    

}
