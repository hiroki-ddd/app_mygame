using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Chi : MonoBehaviour {
	public GameObject enemy;
	float timer;
	float Rounder;
	// Use this for initialization
	void Start () {
		timer = 0;
		Instantiate (enemy, this.transform.position + new Vector3(0,Random.Range(0,20f),0),this.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
			if (timer > 10f) {
				Instantiate (enemy, this.transform.position + new Vector3 (0, Random.Range (0, 20f), 0), this.transform.rotation);
				timer = 0f;
			}
		}
}
