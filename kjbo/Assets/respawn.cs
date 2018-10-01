using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    //Nombramos un public gameObject que será instanciado y le asignamos el tiempo de respawn
    public GameObject[] obj;
    public float tiempoMin = 1.5f;
    public float tiempoMax = 3f;
  //Creamos una variable de generar
    void Start()
    {
        Generar();
    }

    
    void Update()
    {

    }
    //Aquí Instanciamos  el objeto que queremos respawnear en la posición del spawn y hacemos un Invoke para generar ese respawn con el tiempo asignado
    void Generar()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
    }
}