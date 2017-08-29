using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //variable for player speed
    public float speed = 5f;

    //variable for holding the player rigidbody
    private Rigidbody2D rig;

    //location where the bullet will fire from
    public GameObject bulletPoint;

    //holds the prefab for the builet
    public GameObject bullet;

    //spped of the bullet
    public float bulletForwardForce;

    public float bulletDestroyTime = 5f;

    //player health
    public int playerHealth = 100;
    public int currentHealth;

	// Use this for initialization
	void Start () {

        //grabs the rigidbody from the player object
        rig = GetComponent<Rigidbody2D>();

        currentHealth = playerHealth;

	}

    // Update is called once per frame
    void Update()
    {

        //variable for moving player left and right
        float hAxis = Input.GetAxis("Horizontal");
        //variable for moving player forward and backward
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, vAxis, 0) * speed * Time.deltaTime;
        rig.MovePosition(transform.position + movement);

    }

}
