using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeMeter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int ObjCount = this.transform.childCount;

		if (ObjCount == 0) {
			SceneManager.LoadScene ("gameover");
		}
	}
}
