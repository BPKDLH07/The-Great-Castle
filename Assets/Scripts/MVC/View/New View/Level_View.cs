using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_View : MonoBehaviour {
    [SerializeField]
    GameObject[] myTiles = new GameObject[12];
    [SerializeField]
    public Level_Manager thePattern = new Level_Manager();

    Vector3 startPosition;
    Vector3 position;
    Quaternion rotation;


	// Use this for initialization
	void Start () {
        thePattern.OrderD2();
        startPosition = transform.position;
        position = startPosition;
        TilesInstance();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TilesInstance() {
        foreach (int i in thePattern.pattern) {
            GameObject tile = myTiles[i];
            GameObject clone = Instantiate(tile, position, rotation);

            position = clone.transform.Find("Exit").position;
            rotation = clone.transform.Find("Exit").rotation;
        }
        startPosition = transform.position;
        position = startPosition;
    }
}
