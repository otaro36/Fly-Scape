using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punto_llegada : MonoBehaviour
{
    private manageritem palomera;
    // Start is called before the first frame update
    void Start()
    {
        palomera = GameObject.Find("manager").GetComponent<manageritem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "personaje_paloma")
        {
            palomera.mensajes_en_nivel--;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "personaje_paloma")
        {
            palomera.mensajes_en_nivel++;
        }
    }
}
