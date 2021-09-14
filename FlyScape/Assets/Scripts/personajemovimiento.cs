using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class personajemovimiento : MonoBehaviour
{
    public float altitud;
    public float oxigeno=100;
    public float tiempo;
    public float limite_altitud;
    public float limite_tiempo;
    public TextMeshProUGUI mensaje_altitud;
    private Rigidbody2D m_rig;//1
    private float h;//1
    private float v;//1
    [Range(0, 10)] public float speed;//1
    public DynamicJoystick joystick;//1
    public Transform punto_instancia;
    public GameObject bala;
    public bool inicia_mirando_derecha;
    Vector2 la_escala;
    public Scrollbar BarraDeSalud;
    public float Salud = 100;
    private float menosSalud;
    public Button disparo;

    void Start()
    {
        m_rig = GetComponent<Rigidbody2D>();//1
    }
    void Update()
    {
#if UNITY_STANDALONE
        h = Input.GetAxis("Horizontal");
        m_rig.velocity = new Vector2(v * speed, m_rig.velocity.y);//1
        v = Input.GetAxis("Vertical");//1
        m_rig.velocity = new Vector2(h * speed, m_rig.velocity.x);//1
        altitud = transform.position.y;
#endif
#if UNITY_ANDROID
        h = joystick.Horizontal;//1
        m_rig.velocity = new Vector2(v * speed, m_rig.velocity.y);//1
        v = joystick.Vertical;//1
        m_rig.velocity = new Vector2(h * speed, m_rig.velocity.x);//1
        altitud = transform.position.y;
#endif
#if UNITY_EDITOR
        h = Input.GetAxis("Horizontal");
        m_rig.velocity = new Vector2(v * speed, m_rig.velocity.y);//1
        v = Input.GetAxis("Vertical");//1
        m_rig.velocity = new Vector2(h * speed, m_rig.velocity.x);//1
        altitud = transform.position.y;
#endif

        if (altitud> limite_altitud)
        {
            tiempo += 2 * Time.deltaTime;
            mensaje_altitud.gameObject.SetActive(true);
            if (tiempo> limite_tiempo)
            {
                oxigeno--;
                tiempo = 0;
            }
        }
        if (altitud < limite_altitud)
        {
            mensaje_altitud.gameObject.SetActive(false);
        }


    }
    public void disparos()
    {
        Instantiate(bala, punto_instancia.position, Quaternion.identity);
    }
    private void LateUpdate()
    {
        if (h > 0 && inicia_mirando_derecha)
        {
        flip();
        }
        else if (h < 0 && !inicia_mirando_derecha)
        {
        flip();
        }
    }
    void flip()
        {
            inicia_mirando_derecha = !inicia_mirando_derecha;
            la_escala = transform.localScale;
            la_escala.x *= -1;
            transform.localScale = la_escala;
        }
    //1 - esta son ls partes del codigo encargadas del movimiento del personaje
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="enemigo")
        {
            menosSalud = 10f;
            Salud -= menosSalud;
            BarraDeSalud.size = Salud / 100f;
            if(Salud == 0)
            {
                SceneManager.LoadScene("Inicio");
            }
        }
    }    
}
