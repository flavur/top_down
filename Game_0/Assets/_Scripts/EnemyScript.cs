using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private PlayerController playerObject;

	// Use this for initialization
	void Start () {
        playerObject = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerObject.currentHealth -= 20;
            Debug.Log(playerObject.currentHealth);
        }
    }
}
