using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardarycargar : MonoBehaviour
{
    public int nivel_superado;


    // Update is called once per frame
    void Update()
    {
            Guardar();
    }
    public void Guardar()
    {
        PlayerPrefs.SetInt("niveles",nivel_superado);
        print(nivel_superado);
    }
}
