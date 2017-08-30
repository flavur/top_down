using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private PlayerController playerObject;
    private LevelManager levelManagerObject;

	// Use this for initialization
	void Start () {
        playerObject = FindObjectOfType<PlayerController>();
        levelManagerObject = FindObjectOfType<LevelManager>();
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
            //makes sure health value is between 0-1 for adjusting the healthbar local scale
            float myHealth = playerObject.currentHealth / playerObject.maxHealth;
            Debug.Log(myHealth);
            levelManagerObject.SetHealthBar(myHealth);

        }
    }
}
