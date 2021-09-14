using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomenemigos : MonoBehaviour
{
    public float tiempo;
    public int rambom;
    public int limite;
    public GameObject enemigo1;
    //public GameObject enemigo2;
    //public GameObject enemigo3;
    public Transform punto_instancia1;
    public Transform punto_instancia2;
    public Transform punto_instancia3;
    // Start is called before the first frame update
    void Start()
    {
        limite = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo<=limite)
        {
            tiempo += 2 * Time.deltaTime;
        }
        else
        {
            if (rambom==1)
            {
                Instantiate(enemigo1, punto_instancia1.position, Quaternion.identity);
            }
            else if (rambom==2)
            {
                Instantiate(enemigo1, punto_instancia2.position, Quaternion.identity);
            }
            else if (rambom==3)
            {
                Instantiate(enemigo1, punto_instancia3.position, Quaternion.identity);
            }
            tiempo = 0;
            limite = Random.Range(1, 5);
            rambom = Random.Range(1, 4);
        }
    }
}
