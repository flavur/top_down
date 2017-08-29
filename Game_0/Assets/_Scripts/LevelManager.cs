using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //Grab health bar gameobject
    public GameObject healthBar;
    //Grab player script
    public PlayerController playerObject;

	// Use this for initialization
	void Start () {

        //set healthbar gameobject
        healthBar = GameObject.Find("bar");
        //grab the player script
        playerObject = FindObjectOfType<PlayerController>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Scripts for health bar calculation
    /// </summary>
    /// <param name="myHealth"></param>
    public void SetHealthBar(int myHealth)
    {
        healthBar.transform.localScale = new Vector2(playerObject.currentHealth/playerObject.currentHealth, healthBar.transform.localScale.y);
    }
}
