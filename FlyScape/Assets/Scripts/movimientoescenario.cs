using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoescenario : MonoBehaviour

{
    public Transform movimiento_escena;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        movimiento_escena= GameObject.Find("movimiento escenario").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, movimiento_escena.position, velocidad * Time.deltaTime);
    }
}
