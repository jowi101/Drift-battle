using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    private int forward;
    float x;
    float y;
    private Rigidbody r;
    // Use this for initialization
    void Start()
    {
        r = transform.GetComponent<Rigidbody>();
        x = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward);
        x += Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward);
        Quaternion rotation = Quaternion.Euler(0, x, 0);
        transform.rotation = rotation;

        Vector3 forward = new Vector3(0.0f, 0.0f, y);
        r.AddForce(forward * 15);

    }
}