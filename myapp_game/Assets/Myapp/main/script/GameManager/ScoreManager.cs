using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 忘れずに！

public class ScoreManager : MonoBehaviour {

	public int score = 0;
	public int figure=1;
	private Text scoreLabel;
	private Text counter;

	float timer;

	void Start () {

		scoreLabel = GameObject.Find ("ScoreLabel").GetComponent<Text> ();
		scoreLabel.text =score.ToString();

	}
	// スコアを増加させるメソッド
	// 外部からアクセスするためpublicで定義する
	void Update(){
		timer += Time.deltaTime;
		if (timer > 20f) {
			figure++;
			timer = 0;
		}
		counter = GameObject.Find ("Counter").GetComponent<Text> ();
		counter.text =figure.ToString();
	}
	public void AddScore(int amount){
		score += amount;
		scoreLabel.text =score.ToString();
	}
}