using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movtouch : MonoBehaviour
{
    private int forward;
    float x;
    float ejey;
    private Rigidbody r;
    public float speed;
    public float speedRotation;


    
    // Use this for initialization
    void Start()
    {
        speed = 100.0f;
        r = transform.GetComponent<Rigidbody>();
        x = transform.eulerAngles.y;
        speedRotation = 200.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
       

        transform.Translate(Vector3.forward);
        Quaternion rotation = Quaternion.Euler(0, x* speedRotation*Time.deltaTime, 0);
        transform.rotation = rotation;

        Vector3 forward = new Vector3(0.0f, 0.0f, ejey);
        r.AddForce(forward* speed*Time.deltaTime);
        Touch myTouch = Input.GetTouch(0);
        Touch[] myTouches = Input.touches;
        for (int i = 0; i < Input.touchCount; i++);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
            transform.Translate(-touchDeltaPosition.x * speed*Time.deltaTime, -touchDeltaPosition.y * speed*Time.deltaTime, 0);
        }
    }
}
