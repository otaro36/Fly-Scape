using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class canvasinterface : MonoBehaviour
{
    public cambio_nivel cambio;
    public GameObject pause;

    public void Start()
    {
        cambio = GameObject.Find("manager").GetComponent<cambio_nivel>();
    }
    public void cambio_escena() 
    {

        Time.timeScale = 1f;
    }
   
}
