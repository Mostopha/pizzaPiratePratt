using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownMovement : MonoBehaviour {

    public Rigidbody rb;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        

        if (moveSpeed == 0) {
            moveSpeed = 100f;
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetVelocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        // rb.velocity = targetVelocity * moveSpeed;

        rb.AddForce(targetVelocity * moveSpeed);
      
    }
}
