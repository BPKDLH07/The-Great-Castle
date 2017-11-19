using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialScriptLevels : MonoBehaviour
{
    
    //Toque un Poco el Controlador para probar este script, No es un script final -Daniel

    public enum TileType
    {
        TileA, TileB, TileC
    }

    public GameObject[] misTiles;
    public TileType[] pattern;

    Vector3 starPosition;
    Vector3 position;

    Quaternion rotation;

    // Use this for initialization
    void Start()
    {
        //Vector3 starPosition = transform.position;
        //Vector3 position = starPosition;

        //Quaternion rotation = transform.rotation;

        starPosition = transform.position;
        position = starPosition;

        foreach (int p in pattern)
        {
            GameObject tile = misTiles[p];
            GameObject clone = Instantiate(tile, position, rotation);

            position = clone.transform.Find("Exit").position;
            rotation = clone.transform.Find("Exit").rotation;

            //position = clone.transform.Find("Exit1").position;
            //rotation = clone.transform.Find("Exit1").rotation;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
