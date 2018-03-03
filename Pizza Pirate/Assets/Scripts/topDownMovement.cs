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
       Vector3 targetVelocity = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));

        // rb.velocity = targetVelocity * moveSpeed;

        //rb.AddForce(targetVelocity * moveSpeed);

        Vector3 movement = transform.rotation * Vector3.forward;

        rb.AddForce(movement);

        if (Input.GetAxis("Horizontal") >0) {
            transform.Rotate(Vector3.down);
        }
        if (Input.GetAxis("Horizontal") < 0) {
            transform.Rotate(Vector3.up);
        }

    }
}
