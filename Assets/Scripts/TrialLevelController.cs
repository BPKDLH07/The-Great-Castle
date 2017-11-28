using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialLevelController : MonoBehaviour {  
      
    [SerializeField]
    private GameObject[] myTiles;
    [SerializeField]
    Level_Manager thePattern=new Level_Manager();  

    Vector3 startPosition;
    Vector3 position;
    Quaternion rotation; 

    public GameObject piece;       
    

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        position = startPosition;
    }

    void Update(){
    if(Input.GetKeyDown(KeyCode.Q)){
        thePattern.Order1();
        InstanciaTiles();
    }
     if(Input.GetKeyDown(KeyCode.W)){
        thePattern.Order2();
        InstanciaTiles();
    }
     if(Input.GetKeyDown(KeyCode.S)){
        thePattern.Order3();
        InstanciaTiles();
    }
     if(Input.GetKeyDown(KeyCode.A)){
        thePattern.Order4();
        InstanciaTiles();
    }

    }    

    void InstanciaTiles() {
        foreach (int i in thePattern.pattern)
        {
            GameObject tile = myTiles[i];
            GameObject clone = Instantiate(tile, position, rotation);

            position = clone.transform.Find("Exit").position;
            rotation = clone.transform.Find("Exit").rotation;            
        }
        startPosition = transform.position;
        position = startPosition;

    }
	
}
