using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberRenderer : MonoBehaviour {

	public LineRenderer[] lineRederers = new LineRenderer[2];

	private GameObject targetCube;
	private bool isVisible = false;

	public Vector3[] startPositions;

	void Start(){
		lineRederers [0].SetPosition (0, startPositions [0]);
		lineRederers [1].SetPosition (0, startPositions [1]);
	}
	
	// Update is called once per frame
	void Update () {
		if (isVisible) {
			lineRederers [0].SetPosition (1, targetCube.transform.position+new Vector3(-1,-1,0));
			lineRederers [1].SetPosition (1, targetCube.transform.position+new Vector3(1,-1,0));
		}
	}

	public void SetIsVisible(bool flg){
		isVisible = flg;
		lineRederers [0].enabled = flg;
		lineRederers [1].enabled = flg;
	}

	public void SetTargetCube(GameObject obj){
		targetCube = obj;
	}
}
