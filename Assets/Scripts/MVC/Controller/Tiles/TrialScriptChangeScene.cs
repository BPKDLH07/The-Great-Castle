using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialScriptChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeScene(int index){
		SceneManager.LoadScene(index);
	}
}
