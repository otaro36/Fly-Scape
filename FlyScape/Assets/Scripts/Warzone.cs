using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warzone : MonoBehaviour
{
    public GameObject luzUno;
    public GameObject luzDos;
    public GameObject personaje;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "personaje_paloma")
        {
            luzUno.SetActive(true);
            luzDos.SetActive(false);
        }
        else
        {
            luzUno.SetActive(false);
            luzDos.SetActive(true);
        }
    }
}
