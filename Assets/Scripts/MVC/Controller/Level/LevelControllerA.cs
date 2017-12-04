using UnityEngine;

public class LevelControllerA : MonoBehaviour {

    [SerializeField]
    GameObject[] objects = new GameObject[12];
    [SerializeField]
    Level_View levelview;
    
    GameManager theGameManager;

	// Use this for initialization
	void Start () {

        
    objects[0] = GameObject.Find ( "ModuUpLeft(Clone)");
    objects[1] = GameObject.Find ( "ModuUpRight(Clone)");
    objects[2] = GameObject.Find ( "ModuDownRight(Clone)");
    objects[3] = GameObject.Find ( "ModuDownLeft(Clone)");

    objects[4] = GameObject.Find ( "IniModuUpLeft(Clone)");
    objects[5] = GameObject.Find ( "IniModuUpRight(Clone)");
    objects[6] = GameObject.Find ( "IniModuDownRight(Clone)");
    objects[7] = GameObject.Find ( "IniModuDownLeft(Clone)");

    objects[8] = GameObject.Find ( "EndModuUpLeft(Clone)");
    objects[9] = GameObject.Find ( "EndModuUpRight(Clone)");
    objects[10] = GameObject.Find ( "EndModuDownRight(Clone)");
    objects[11] = GameObject.Find ( "EndModuDownLeft(Clone)");

        levelview = GameObject.Find("LevelManagerChildren").GetComponent<Level_View>();

         theGameManager = GameObject.Find("GameManager").GetComponent<GameManager>();   

    }

    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {   
            theGameManager.theTime.MoreTimeBar();

            levelview.thePattern.OrderA3();
            levelview.TilesInstance();


            Destroy(objects[0]);
            Destroy(objects[1]);
            Destroy(objects[2]);
            Destroy(objects[3]);

            Destroy(objects[4]);
            Destroy(objects[5]);
            Destroy(objects[6]);
            Destroy(objects[7]);
            
            Destroy(objects[8]);
            Destroy(objects[9]);
            Destroy(objects[10]);
            Destroy(objects[11]);

        }
    }

}
