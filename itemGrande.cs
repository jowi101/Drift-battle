using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGrande : MonoBehaviour {
    float x;
    float y;
    float z;
    Vector3 newSize;
   

     void Update()
    {
        x += 0.1f;
        y += 0.1f;
        z += 0.1f;
     

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Grande")
        {
            transform.localScale += new Vector3(x, y, z);
            gameObject.tag = "Muere";
        }
    }
    
       
}
