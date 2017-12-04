using UnityEngine;

public class RightCollider : MonoBehaviour {

    Enemy_Controller enemyControl;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {

        enemyControl = GameObject.Find("EnemyTrial").GetComponent<Enemy_Controller>();

        if (other.tag == "Player")
        {
            enemyControl.enemy.theEnemyFront = Enemy_View.CharacterViewFront.right;
            enemyControl.transform.Rotate(0, 90, 0);

            Debug.Log("ve a la derecha");

        }

    }
}
