using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemyManager : MonoBehaviour {

    public float enemyRemaining;
    public Text enemyCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        enemyCount.text = enemyRemaining.ToString();
        enemyRemaining = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (GameObject.FindGameObjectsWithTag("Enemy").Length < 1) {
            SceneManager.LoadScene(1);

        }


    }


}
