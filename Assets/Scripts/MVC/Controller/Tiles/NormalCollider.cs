using UnityEngine;

public class NormalCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.tag=="Player"){
			Debug.Log("Esta Parado");
		}
	}
}
