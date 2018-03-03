using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBullet : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("e")) {
            GameObject shooty = GameObject.Instantiate(bullet, transform);

            Vector3 shootyVector = transform.rotation * Vector3.right*1000;

            shooty.GetComponent<Rigidbody>().AddForce(shootyVector);
        }
	}
}
