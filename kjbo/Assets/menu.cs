using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject botonesMenu;


    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()


    {
    }

    public void empiezaMotos()
    {
        SceneManager.LoadScene("juego");
    }
    public void menuMotos()
    {
        SceneManager.LoadScene("Controles");
    }

    public void otraMenu()
    {
        SceneManager.LoadScene("MenuTouch");
    }
  
}