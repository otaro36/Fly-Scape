using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manageritem : MonoBehaviour
{
    public Text texto;
    public cambio_nivel nivel_superado;
    public int mensajes;
    public int mensajes_en_nivel;
    public GameObject panel;
    //public int nivel_a_cargar;
    private void Awake()
    {
        nivel_superado = GameObject.Find("manager").GetComponent(typeof(cambio_nivel)) as cambio_nivel;

    }

    void Update()
    {

        texto.text = "" + mensajes;
        if (mensajes == mensajes_en_nivel)
        {
            nivel_superado.Desbloquear_Nivel();
            nivel_superado.CambiarNivel(1);
        }

    }
    /*IEnumerator Victoria()
    {

        yield return new WaitForSecondsRealtime(30f);


    }*/
}
