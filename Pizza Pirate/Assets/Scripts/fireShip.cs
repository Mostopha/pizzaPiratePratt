using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fireShip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.name == "Player") {
            

            Destroy(coll.gameObject);

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            Invoke("restartScene", 3);

            //restartScene();

        }
    }

    void restartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
