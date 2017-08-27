using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    int timerTest = 5;

	// Use this for initialization
	void Start () {

        changeColor(timerTest);

    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.black;
        }

	}

  public void changeColor(int number)
    {
        for (int myNumber = 0; myNumber < number; myNumber++)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            Debug.Log(myNumber);
        }
    }
}
