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

	// Use this for initialization
	void Start () {

        //grabs the rigidbody from the player object
        rig = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        //variable for moving player left and right
        float hAxis = Input.GetAxis("Horizontal");
        //variable for moving player forward and backward
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, vAxis, 0)*speed*Time.deltaTime;
        rig.MovePosition(transform.position + movement);

        if (Input.GetMouseButtonDown(0))
        {
            //Bullet instantiation
            GameObject tempBulletHolder = Instantiate(bullet,bulletPoint.transform.position,bulletPoint.transform.rotation);
            tempBulletHolder.transform.Rotate(Vector3.left * 90);

            //Retrieve the rigidbody component from the instantiated bullet and control it
            Rigidbody tempRigidbody = tempBulletHolder.GetComponent<Rigidbody>();
            //Tell the bullet object to be pushed forward
            tempRigidbody.AddForce(transform.forward * bulletForwardForce);

            //Basic cleanup, sets the bullet to be destroyed after a certain amount of time
            Destroy(tempBulletHolder, bulletDestroyTime);
        }

    }
}
