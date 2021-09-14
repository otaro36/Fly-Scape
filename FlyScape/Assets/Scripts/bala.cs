using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    private Rigidbody2D m_rig;
    public personajemovimiento a_donde_disparo;
    [Range(0, 30)] public float speed;
    Vector2 la_escala;
    public bool inicia_mirando_derecha;
    public int dirrecion_bala;
    public GameObject impacto_derecha;
    public GameObject impacto_izquierda;

    // Start is called before the first frame update
    void Start()
    {
        a_donde_disparo = FindObjectOfType<personajemovimiento>();
        if (a_donde_disparo.inicia_mirando_derecha)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            this.gameObject.GetComponent<Transform>().localScale = transform.localScale * -1;
            //transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (!a_donde_disparo.inicia_mirando_derecha)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            //transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "pisos"|| other.gameObject.tag == "enemigo"|| other.gameObject.tag == "bala_enemigo")
        {
            if (this.transform.localScale.x<0)
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
