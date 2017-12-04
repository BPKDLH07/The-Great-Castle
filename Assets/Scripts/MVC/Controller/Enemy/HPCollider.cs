using UnityEngine;

public class HPCollider : MonoBehaviour {

	GameObject enemy;
	GameManager theGameManager;
	
	UI_ViewManager UImanager;

	// Use this for initialization
	void Start () {
		
	enemy = GameObject.Find("EnemyTrial");

	theGameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

	UImanager = GameObject.Find("DontDestroyCanvas").GetComponent<UI_ViewManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


void OnTriggerEnter(Collider other)
{
	if (other.tag == "sword"){
		theGameManager.theTime.PointBonus();
		Destroy(enemy);


	}
	else if (other.tag =="Player"){

		UImanager.NextScene(2);

	}

}

}
