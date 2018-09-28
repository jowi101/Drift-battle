using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour {

    public static float speed = 10.0f;
    private Rigidbody body;
    public float rotate = 10.0f;

	// Use this for initialization
	void Start () {

       
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, rotate * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -rotate * Time.deltaTime, 0);
        }


    }
}
