using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour {

    private string itemName;
    public PlayerController playerObject;

	// Use this for initialization
	void Start () {
        itemName = this.gameObject.name;
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
            if(itemName == "Health")
            {
                playerObject.playerHealth++;
            }
        }
    }
}
