using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {
    public float speed=10f;
    public GameObject explision;

	void Start()
	{
		this.transform.rotation = Quaternion.Euler (90,0,0);
	}

	// Update is called once per frame
	void Update () {
        //transform.localPosition += transform.forward * speed;

		this.transform.position -= new Vector3 (0, speed * Time.deltaTime, 0);
		Destroy (this.gameObject, 10f);
	}
	/*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Respawn")
        {
            Destroy(gameObject);
            Instantiate(explision, transform.position, Quaternion.identity);
        }
    }
*/
	void OnTriggerEnter(Collider col){

		//花に当った時
		if (col.gameObject.tag == "life") {
			Destroy (this.gameObject);
			Instantiate(explision, transform.position, transform.rotation);
		}

		//地面に当たった時
		if (col.gameObject.tag == "ground") {
			Destroy (this.gameObject);
			Instantiate(explision, transform.position, Quaternion.identity);  
			//GameObjectとしてexplosinを生成
//			Instantiate(explision) as GameObject;//GameObjectとしてexplosinを生成
		}

	}
}
