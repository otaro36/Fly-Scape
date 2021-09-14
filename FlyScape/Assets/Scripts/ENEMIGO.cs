using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMIGO : MonoBehaviour
{
    public Transform posicion_personaje;
    private Rigidbody2D m_rig;
    public personajemovimiento a_donde_disparo;
    [Range(0, 10)] public float speed;
    Vector2 la_escala;
    public bool inicia_mirando_derecha;
    public int dirrecion_bala;
    public GameObject impacto_derecha;
    public GameObject impacto_izquierda;
    public int conteo_balas;
    public float tiempo;

    public void Start()
    {
        posicion_personaje = GameObject.Find("personaje_paloma").transform;
        m_rig = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Update()
    {
        //a_donde_disparo = FindObjectOfType<personajemovimiento>();
        //if (!a_donde_disparo.inicia_mirando_derecha)



        tiempo += 0.1f;
        if (tiempo > 100)
        {
            if (this.transform.position.x >= posicion_personaje.position.x)
            {
                // transform.Translate(Vector2.left * speed * Time.deltaTime);
                m_rig.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
                //Destroy(this);
            }
            else
            {
                //transform.Translate(Vector2.right * speed * Time.deltaTime);
                m_rig.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
                //Destroy(this);

            }

            //Destroy(this.gameObject);
        }
        else
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, posicion_personaje.position, speed * Time.deltaTime);
        }
        //this.gameObject.GetComponent<Transform>().localScale = transform.localScale * -1;
        //transform.Translate(Vector2.left * speed * Time.deltaTime);

        //if (a_donde_disparo.inicia_mirando_derecha)
        {
            //this.gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            //transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "pisos" || other.gameObject.tag == "personaje" || other.gameObject.tag == "bala")
        {
            if (this.transform.localScale.x < 0)
            {
                Instantiate(impacto_derecha, this.transform.position, this.transform.rotation);
            }
            else
            {
                Instantiate(impacto_izquierda, this.transform.position, this.transform.rotation);
            }


            Destroy(this.gameObject);
        }

    }
}
