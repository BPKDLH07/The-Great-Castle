using UnityEngine;

public class SpikesCollider : MonoBehaviour {

	GameManager theGameManager;

	// Use this for initialization
	void Start () {
		
		theGameManager=GameObject.Find("GameManager").GetComponent<GameManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.tag=="Player"){

			theGameManager.Player.Auch();
			Debug.Log("SePinchó");
		}
	}
}
