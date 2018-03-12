using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot_Chi : MonoBehaviour {
	public GameObject bom;
	float timer;
	float R,R1,R2;
	// Use this for initialization
	private ScoreManager sm;
	//ラウンド
	int num;

	void Start () {
		R = Random.Range (5f, 10f);
		R1 = Random.Range (3f, 8f);
		R2 = Random.Range (1f, 2f);
		sm = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		SC ();
	}
	void SC(){
		timer += Time.deltaTime;

		num = sm.figure;
		switch (num) {
		case 1:
			if (timer > R) {
				Instantiate (bom, this.transform.position, this.transform.rotation);
				timer = 0;
			}
			break;
		case 2:
			if (timer > R1) {
				Instantiate (bom, this.transform.position, this.transform.rotation);
				timer = 0;
			}
			break;
		case 3:
			if (timer > R2) {
				Instantiate (bom, this.transform.position, this.transform.rotation);
				timer = 0;
			}
			break;
		default:
			if (timer > R2) {
				Instantiate (bom, this.transform.position, this.transform.rotation);
				timer = 0;
			}
			break;
		}
	}
}
