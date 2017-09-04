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
    public float maxHealth = 100;
    public float currentHealth;

    //dash speed
    public float dashSpeed = 10f;
    public float dashDistance = 10f;

    // Use this for initialization
    void Start () {

        //grabs the rigidbody from the player object
        rig = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;

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

        /*
         * //setup dash move
        if (hAxis == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.MovePosition(transform.position + movement * dashSpeed);
            }
        }
        if (hAxis == -1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.MovePosition(transform.position + movement * dashSpeed);
            }
        }
        if (vAxis == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.MovePosition(transform.position + movement * dashSpeed);
            }
        }
        if (vAxis == -1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.MovePosition(transform.position + movement * dashSpeed);
            }
        }
        */

    }

}
