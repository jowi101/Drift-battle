using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemMuerte : MonoBehaviour
{

    public GameObject personaje;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(personaje, 0);
        }
    }
}
    
       
