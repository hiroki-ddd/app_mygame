using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Co : MonoBehaviour {
	public float speed=10f;
	float timer=0f;
	//スコア
	public int scoreValue=100;
	private ScoreManager sm;
	//ラウンド
	int num;

	// Use this for initialization
	void Start () {
		sm = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		SC ();
		Destroy (this.gameObject, 20f);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			sm.AddScore (scoreValue);
		}
	}

	void SC(){
		num = sm.figure;
		switch (num) {
		case 1:
			break;
		case 2:
			break;
		case 3:
			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
			break;
		default:
			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
			break;
		}
	}
}
