using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public GameObject botonesMenu;


    
    void Start()
    {

    }
    
    void Update()


    {
    }
    //Creamos las variables para todos los botones que queramos utilizar y le asignamos la escena que queremos cargar

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