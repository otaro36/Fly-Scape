using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemigovolador : MonoBehaviour
{
    private Transform personaje;
    public float vida;
    public float vida_inicial;
    public Image barra_vida;
    public float distacncia;
    public float distancia_frenado;
    public float distancia_retraso;
    [Range(1,5)] public float velocidad;
    public float daño;
    public double x = -0.1;
    Animator caminar;
    Animator idle;
    public Transform punto_instancia;
    public GameObject bala;
    private float tiempo;
    public GameObject carta;
    public puertamiobil enemigo_vencido;
    public GameObject explosion_muerte;


    // Start is called before the first frame update
    void Start()
    {
        
        daño = Random.Range(20, 50);
        distacncia = Random.Range(8, 12);
        vida = Random.Range(700 , 800);
        personaje = GameObject.Find("personaje_paloma").transform;
        vida_inicial = vida;
        caminar = GetComponent<Animator>();

    }
    void Update()
    {
            if (Vector2.Distance(personaje.position, transform.position) > distancia_frenado)
            {
                this.transform.position = Vector2.MoveTowards(this.transform.position, personaje.position, velocidad * Time.deltaTime);
            }
            if (Vector2.Distance(personaje.position, transform.position) < distancia_retraso)
            {
                this.transform.position = Vector2.MoveTowards(this.transform.position, personaje.position, -velocidad * Time.deltaTime);
            }
            if (Vector2.Distance(personaje.position, transform.position) < distancia_frenado && (Vector2.Distance(personaje.position, transform.position) > distancia_retraso))
            {
                transform.position = transform.position;
            }
        carta.transform.position = this.transform.position;

        if (vida <= 0)
        {
            Instantiate(explosion_muerte, punto_instancia.position, Quaternion.identity);
            enemigo_vencido.enemigos_vencidos++;
            carta.SetActive(true);          
            Destroy(this.gameObject);
        }
        if (personaje.position.x > this.transform.position.x)
        {
            this.transform.localScale = new Vector2(-1f, 1f);
        }
        else
        {
            this.transform.localScale = new Vector2(1f, 1f);
        }
        tiempo += Time.deltaTime;
        if (tiempo > 2)
        {
            Instantiate(bala, punto_instancia.position, Quaternion.identity);
            tiempo = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bala")
        {
            vida -= 10;
            barra_vida.fillAmount = vida / vida_inicial;
        }
    }
}
