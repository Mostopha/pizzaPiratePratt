using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour {
    public float health;
    public float fullHealth;
    public Image healthbar;
    

	// Use this for initialization
	void Start () {
        if (health == 0) {
            health = 10;
        }

        //healthbar = this.transform.Find("healthBar").gameObject.GetComponent<Image>();
        fullHealth = health;   
	}
	
	// Update is called once per frame
	void Update () {
        if (health < 1) {
            Destroy(this.gameObject);
        }

        healthbar.fillAmount = health / fullHealth;
	}
}
