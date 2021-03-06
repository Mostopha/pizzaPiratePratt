﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public LayerMask layerMasque;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Physics.IgnoreCollision(this.GetComponent<Collider>(), GameObject.Find("Player").GetComponent<Collider>());

        Invoke("destroySelf", 2);
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.GetComponent<enemy>()) {

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            col.gameObject.GetComponent<enemy>().health -= 2;
        }
       

    }

    void destroySelf() {
        Destroy(this.gameObject);
    }
}
