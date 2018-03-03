using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPlayer : MonoBehaviour {

    public bool canShoot;
    public bool isReloading;
    public GameObject enemyBullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider coll) {
        if (coll.name == "Player") {
            GameObject shooty = GameObject.Instantiate(enemyBullet, transform);

            Vector3 shootDirection = this.transform.position - coll.transform.position;

            shooty.GetComponent<Rigidbody>().AddForce(-shootDirection*100);

            

            shooty.transform.parent = null;


        }
    }

    
}
