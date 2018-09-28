using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp2 : MonoBehaviour {

   
    public  bool indestructible;
    public bool tiempo;
    public float timing;
   


    private void Awake()
    {
        indestructible = false;
        tiempo=false;
        timing = 10.0f;
        
    }

    //Power up active     
    //Power Up destruction
    //Wall destruction

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "powerUp1")
        {
            Destroy(collision.gameObject, 0);
            indestructible = true;
            contador();
        }

        if (collision.gameObject.tag == "Wall")
        {

            if (!indestructible)
            {
                Destroy(this.gameObject, 0);
            }
        }

        if (collision.gameObject.tag == "Obstaculo")
        {
            if (!indestructible)
            {
                Destroy(this.gameObject, 0);
            }

        }
        
        if (collision.gameObject.tag == "Obstaculo")
        {
            if (indestructible)
            {
                Destroy(collision.gameObject, 0);
            }

        }
        //Si hay mas jugadores como lo harias Jose??
        if (collision.gameObject.tag == "Enemy")
        {
            if (indestructible)
            {
                Destroy(collision.gameObject, 0);
            }
        }
    }
    void contador()
    {
        tiempo = true;
        timing -= Time.deltaTime;

        if (timing <= 0)
        {
            tiempo = false;
        }
    }
    
           
    

}