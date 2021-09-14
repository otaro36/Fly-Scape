using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paracaidista : MonoBehaviour
{
    public GameObject torreta;
    public GameObject btnDisparar;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "personaje_paloma")
        {
            torreta.SetActive(true);
            btnDisparar.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
