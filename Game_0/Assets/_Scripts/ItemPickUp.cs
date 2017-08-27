using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour {

    private string itemName;
    public PlayerController playerObject;
    public int healthPickupV2 = 10;

	// Use this for initialization
	void Start () {
        playerObject = FindObjectOfType<PlayerController>();
        itemName = this.gameObject.name;
        Debug.Log(itemName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
            //Update health if item is a healthpack
            if(itemName == "Health")
            {
                playerObject.playerHealth += 50;
                //Debug.Log(playerObject.playerHealth);
            }
        }
    }
}
