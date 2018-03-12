using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Co : MonoBehaviour {
	public GameObject enemy;
	float timer;
	float Rounder;
	private ScoreManager sm;
	int round;
	// Use this for initialization
	void Start () {
		timer = 0;
		sm = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
	}

	// Update is called once per frame
	void Update () {
		SC ();
	}
	void SC(){
		round = sm.figure;
		timer += Time.deltaTime;
		switch (round) {
		case 1:
			break;
		case 2:
			break;
		case 3:
			if (timer > 10f) {
				Instantiate (enemy, this.transform.position + new Vector3 (0, Random.Range (0, 20f), 0), this.transform.rotation);
				timer = 0f;
			}
			break;
		default:
			if (timer > 10f) {
				Instantiate (enemy, this.transform.position + new Vector3 (0, Random.Range (0, 20f), 0), this.transform.rotation);
				timer = 0f;
			}
			break;
		}
	}
}
