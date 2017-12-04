using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy_View : MonoBehaviour {
	
	void Awake(){
		DontDestroyOnLoad(this.gameObject);
	}
	
}
