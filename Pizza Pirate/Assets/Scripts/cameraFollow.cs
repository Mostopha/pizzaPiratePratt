using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    // Use this for initialization
    public GameObject player;

    private Vector3 offset;

    // Use this for initialization
    void Start() {

        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate() {

        transform.position = player.transform.position + offset;

        //transform.position = Vector3.Lerp(player.transform.position, offset, 1);
    }
}
