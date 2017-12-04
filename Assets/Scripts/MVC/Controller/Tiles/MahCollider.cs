using UnityEngine;

public class MahCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Floor") {
            Debug.Log("Estoy Parado");
        }
    }

    void OnTriggerStay(Collider other) {
        if (other.tag == "Floor") {
            Debug.Log("Sigo Parado");
        }
    }
    

}


