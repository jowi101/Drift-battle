using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    public  bool vel;
    public float Acelerar;
    public float speed = 10.0f;
    public float force = 20.0f;
    private Rigidbody body;
    public float rotate = 10.0f;


    public void Awake()
    {
        vel = false;
        body = GetComponent<Rigidbody>();        
    }

    

    // Update is called once per frame
    void Update()
    {

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
       //preguntar porque solo acelera un poco
       // timer 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "powerUp2")
        {
            Destroy(collision.gameObject, 0);
            vel = true;
            Acelerar = (speed * force)* Time.deltaTime;


            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, Acelerar);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, -Acelerar);
            }


        }
    }  
}


  

   
