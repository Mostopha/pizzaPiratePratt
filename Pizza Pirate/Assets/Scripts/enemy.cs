using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public float health;

	// Use this for initialization
	void Start () {
        if (health == 0) {
            health = 10;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (health < 1) {
            Destroy(this.gameObject);
        }
	}
}
