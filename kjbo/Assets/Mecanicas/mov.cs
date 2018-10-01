using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{


    private Rigidbody r;
    public float speed;
    public float maxSpeed;
    public GameObject referencia;


    void Start()
    {
        r = transform.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (r.velocity.magnitude > maxSpeed)
        {
            r.velocity = r.velocity.normalized * maxSpeed;
        }

        r.AddForce(referencia.transform.forward * speed);
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Velocidad")
        {
            r.velocity = r.velocity.normalized * maxSpeed * 50;
        }
    }
   
}