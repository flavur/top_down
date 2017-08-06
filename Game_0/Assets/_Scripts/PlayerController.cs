using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //variable for player speed
    public float speed = 5f;

    //variable for holding the player rigidbody
    private Rigidbody2D rig;

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
		
	}
}
