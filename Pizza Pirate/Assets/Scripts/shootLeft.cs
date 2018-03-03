using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootLeft : MonoBehaviour {

    public GameObject bullet;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown("q")) {
            GameObject shooty = GameObject.Instantiate(bullet, transform);

            Vector3 shootyVector = transform.rotation * Vector3.left * 1000;

            shooty.GetComponent<Rigidbody>().AddForce(shootyVector);
        }
    }
}
