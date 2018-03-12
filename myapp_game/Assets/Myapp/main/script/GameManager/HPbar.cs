using UnityEngine;
using System.Collections;

public class HPbar: MonoBehaviour {

	//　苗木のMaxHP

	private int maxHp = 3;
	//　苗木のHP
	private int hp;
	//　苗木のHPバー処理スクリプト
	private HPUI hpUI;

	void Start() {
		hp = maxHp;
		hpUI = GetComponentInChildren <HPUI> ();
	}

	public void SetHp(int hp) {
		this.hp = hp;

		//　HP表示用UIのアップデート
		hpUI.UpdateHPValue ();

		if (hp <= 0) {
			//　HP表示用UIを非表示にする
			hpUI.SetDisable ();

		}
	}

	public int GetHp() {
		return hp;
	}

	public int GetMaxHp() {
		return maxHp;
	}
}
