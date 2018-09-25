using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerteItem : MonoBehaviour {

    public GameObject personaje;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Muere")
        {
            Destroy(personaje, 0);
        }
    }
}
