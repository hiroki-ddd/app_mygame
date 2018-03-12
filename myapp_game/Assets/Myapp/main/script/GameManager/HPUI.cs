using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPUI : MonoBehaviour {

	//　HP表示用スライダー
	private Slider hpSlider;

	void Start() {
		//　HP用Sliderを子要素から取得
		hpSlider = transform.Find ("HPBar").GetComponent <Slider>();
		//　スライダーの値0～1の間になるように比率を計算
	}

	// Update is called once per frame
	void Update () {
	}
	//　死んだらHPUIを非表示にする
	public void SetDisable() {
		gameObject.SetActive (false);
	}

	public void UpdateHPValue() {
	}
}