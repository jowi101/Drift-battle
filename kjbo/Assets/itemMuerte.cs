using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemMuerte : MonoBehaviour
{

    public GameObject personaje;
    //Hacemos que cuando un GameObject con el tag trigge el item se destruya
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(personaje, 0);
        }
    }
}
    
       
