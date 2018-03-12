using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float speed=10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position -= new Vector3 (0,speed * Time.deltaTime, 0);
		Destroy (this.gameObject, 10f);
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "life") {
			Destroy (this.gameObject);
		}
		if (col.gameObject.tag == "ground") {
			Destroy (this.gameObject);
		}
	
	}
}
