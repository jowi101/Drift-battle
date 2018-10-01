﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{

    public GameObject[] obj;
    public float tiempoMin = 1.5f;
    public float tiempoMax = 3f;
    // Use this for initialization
    void Start()
    {
        Generar();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Generar()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
    }
}