using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour {

    private string itemName;
    private PlayerController playerObject;
    public int healthPickupV2 = 10;
    public Vector2 itemPosition;

	// Use this for initialization
	void Start () {
        playerObject = FindObjectOfType<PlayerController>();
        itemName = this.gameObject.name;
        itemPosition = this.gameObject.transform.position;
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
                playerObject.currentHealth += 50;
                Debug.Log(playerObject.currentHealth);
            }
        }
    }

    /*
    public void RespawnItem()
    {
        this.gameObject.SetActive(false);
    }
    */
}
