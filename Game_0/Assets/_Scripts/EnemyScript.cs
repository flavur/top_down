using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private PlayerController playerObject;
    private LevelManager levelManagerObject;

    //Enemy movement
    public float leftrightDistance = 1.5f;
    public float leftrightSpeed = 1.5f;
    private Vector2 startPos;

	// Use this for initialization
	void Start () {
        playerObject = FindObjectOfType<PlayerController>();
        levelManagerObject = FindObjectOfType<LevelManager>();
        //grab the start position
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 newPos = startPos;
        newPos.x+=leftrightDistance*Mathf.Sin(Time.time * leftrightSpeed);
        transform.position = newPos;
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
