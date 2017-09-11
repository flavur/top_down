using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //Grab health bar gameobject
    public GameObject healthBar;
    private ItemPickUp itemObject;

	// Use this for initialization
	void Start () {

        //set healthbar gameobject
        healthBar = GameObject.Find("bar");
        itemObject = FindObjectOfType<ItemPickUp>();

    }
	
	// Update is called once per frame
	void Update () {
        if (itemObject.item.activeInHierarchy == false)
        {
            RespawnItem();
        }
	}

    public void RespawnItem()
    {
        StartCoroutine("Respawn");
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3);
        itemObject.item.SetActive(true);
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector2((Mathf.Clamp(myHealth, 0f, 1f)), healthBar.transform.localScale.y);
    }
}
