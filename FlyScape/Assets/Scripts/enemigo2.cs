using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemigo2 : MonoBehaviour
{
    public Transform posicion_personaje;
    private Rigidbody2D m_rig;
    public float speed;
    public bool arriba=false;
    public bool abajo=false;
    public bool izquierda=false;
    public bool derecha=false;
    public int vida;
    public int vida_inicial;
    public Scrollbar barravidaenemigo;
    public GameObject impacto_derecha;
    public GameObject impacto_izquierda;
    public void Start()
    {
        speed = Random.Range(6,10);
        m_rig = GetComponent<Rigidbody2D>();
        if (arriba)
        {
            m_rig.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        }
        else if (abajo)
        {
            m_rig.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
        }
        else if (izquierda)
        {
            m_rig.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
        }
        else if (derecha)
        {
            m_rig.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }
        speed = Random.Range(6, 10);
        vida = Random.Range(20, 50);
        vida_inicial = vida;
    }
    public void Update()
    {
        
    }

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
        if (other.gameObject.tag == "bala")
        {          
            vida -= 10;
            vida_inicial =vida_inicial/ vida;
            print(vida);
            
            if (vida>=0)
            {
                Destroy(this.gameObject);
            }
        }

    }
}
