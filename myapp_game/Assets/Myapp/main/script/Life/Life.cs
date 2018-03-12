using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
	float life=3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "missile") {
			life--;
			if (life == 0) {
				Destroy (this.gameObject);
			}
		}
	}
}
