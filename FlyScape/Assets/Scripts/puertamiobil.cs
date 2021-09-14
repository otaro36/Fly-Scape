using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertamiobil : MonoBehaviour
{
    public GameObject puerta_mover;
    public Transform punto_final;
    [Range(0, 10)] public float velocidad;
    public int enemigos_vencidos;
    public Vector3 hacia_mover;
    


    // Start is called before the first frame update
    void Start()
    {
        hacia_mover = punto_final.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigos_vencidos == 1)
        {
            puerta_mover.transform.position = Vector3.MoveTowards(puerta_mover.transform.position, hacia_mover, velocidad * Time.deltaTime);
        }

    }
}
