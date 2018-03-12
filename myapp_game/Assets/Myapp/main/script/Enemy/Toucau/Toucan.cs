using UnityEngine;
using System.Collections;

public class Toucan : MonoBehaviour {
    public GameObject missile;
	public GameObject legs;
	public GameObject explision;
	float speed=10f;
	float timer;
	float R;
	bool isAttach=false;
	/*
   Transform player_target;
    bool attack;
    */

	GameManagerScript gameManagerScript;//GameObject.Findで取ってきたGameManagerを格納しておく為の変数→GetComponentで取ってきたGameManagerScriptを格納
	bool isDestroy = false;//Destroyされたかどうかのフラグ

	// Use this for initialization
	void Start () {      
        //player_target = GameObject.Find("Player").transform;
		R = Random.Range (1f, 10f);
		gameManagerScript = GameObject.Find ("GameManager").GetComponent<GameManagerScript>();
	}
	

	// Update is called once per frame
	void Update (){
	/*
		float distance = Vector3.Distance(transform.position, player_target.position);
        transform.localPosition += transform.forward * 0.2f;

        if(attack)
        {
            transform.LookAt(player_target);
            if (distance < 35f)
            {
                Attack();
                attack = false;
            }
        }
        else
        {
            if (distance > 100f) attack = true;
        }
    }


    void Attack()
    {
        transform.localEulerAngles += new Vector3(-20, 0, 0);
        GameObject m = (GameObject)Instantiate(missile, transform.position, Quaternion.identity);
        m.transform.LookAt(player_target);
    }
		*/
		this.transform.position += this.transform.forward*speed * Time.deltaTime;
		Destroy (this.gameObject, 20f);

		timer += Time.deltaTime;
		if (timer > R) {
			Instantiate (missile, this.transform.position, this.transform.rotation);
			timer = 0;
		}
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			Destroy (this.gameObject);//Destroy
			Instantiate(explision, transform.position,transform.rotation); 
			if (isAttach == false) {
				Instantiate (legs, transform.position, transform.rotation);
				isAttach = true;
			}

			if(isDestroy == false)
			{
				gameManagerScript.enemyDestroy++;//Destroyされる度に+1される
				isDestroy = true;
			}
		}
	}


}

