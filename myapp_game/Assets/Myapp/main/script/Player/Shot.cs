using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
	public float max = 300f;
	public float power = 1f;
	Vector3 clickPosDown, clickPosUp, firstBallPos;
	float shotpower;

	bool isShot = false;
	RubberRenderer rubberRenderer;


	Rigidbody rb;

	void Start ()
	{
		rubberRenderer = GameObject.Find ("RubberRenderer").GetComponent<RubberRenderer> ();

		rb = this.gameObject.GetComponent<Rigidbody> ();
		firstBallPos = this.transform.position;
	}

	void Update ()
	{
		/*
		BallShot ();//ボール打つ
		Hoge();//ボール打つまでの間いい感じにする関数
*/
		if (!isShot) {
			ShootFunc ();
		} else {
			if (this.transform.position.y < -100) {
				Destroy (this.gameObject);
			}
		}



	}


	void ShootFunc ()
	{
		if (Input.GetMouseButtonDown (0)) {
			clickPosDown = Input.mousePosition;
		}
		if (Input.GetMouseButton (0)) {
			this.transform.position = firstBallPos + (Input.mousePosition - clickPosDown) / 100;
		}
		if (Input.GetMouseButtonUp (0)) {
			clickPosUp = Input.mousePosition;

			Vector3 direction = (clickPosDown - clickPosUp).normalized;
			shotpower = (clickPosDown - clickPosUp).magnitude / Screen.width;

			if (shotpower > max) {
				shotpower = max;
			}
			rb.velocity = direction * shotpower * power;
			rb.isKinematic = false;
			isShot = true;

//			rubberRenderer.SetIsVisible (false);
		}
	}
	/*
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "enemy") {
			Destroy (col.gameObject);
		}
	}
	/*
	//ボール打つまでの間いい感じにする関数
	void Hoge()
	{
		if(IsShoted == false)//ボール打つ前だけ呼ばれる
		{
			if (Input.GetMouseButton (0)) {
				this.transform.position = firstBallPos + (Input.mousePosition - clickPosDown) / 100;
			}
		}
	}

	//ボール打つ関数
	void BallShot()
	{
		if (Input.GetMouseButtonDown (0)) {
			clickPosDown = Input.mousePosition;
		}

		if (Input.GetMouseButtonUp (0)) {
			clickPosUp = Input.mousePosition;

			Vector3 direction = (clickPosDown - clickPosUp).normalized;
			shotpower = (clickPosDown - clickPosUp).magnitude/Screen.width;

			if (shotpower > max){
				shotpower = max;
			}
			rb.velocity = direction * shotpower * power;
			rb.isKinematic = false;
			isShoted = true;
		}

	}
	*/
}

