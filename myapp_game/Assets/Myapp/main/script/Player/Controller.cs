using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public GameObject player;
	RubberRenderer rubberRenderer;
	// Use this for initialization
	void Start ()
	{
		rubberRenderer = GameObject.Find ("RubberRenderer").GetComponent<RubberRenderer> ();

		GameObject playerClone = Instantiate (player, this.transform.position, this.transform.rotation) as GameObject;
		rubberRenderer.SetIsVisible (true);
		rubberRenderer.SetTargetCube (playerClone);

	}
	
	// Update is called once per frame
	void Update ()
	{
//		if (Input.GetMouseButtonDown (0)) {
//			Debug.Log ("hofge");
		if (Input.GetMouseButtonUp (0)) {
			GameObject playerClone = Instantiate (player, this.transform.position, this.transform.rotation) as GameObject;
			rubberRenderer.SetIsVisible (true);
			rubberRenderer.SetTargetCube (playerClone);
		}

//	}
	}
}