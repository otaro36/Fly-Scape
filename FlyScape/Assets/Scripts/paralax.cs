using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax : MonoBehaviour
{
    public GameObject objEscenario;
    void Start()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "pisos")
        {
            Destroy(objEscenario);
        }
    }
}
