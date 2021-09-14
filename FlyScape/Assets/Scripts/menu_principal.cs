using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menu_principal : MonoBehaviour
{
    public string menu;
    public GameObject pause;
    public GameObject menu_pausa;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    public void pausa()
    {
        Time.timeScale = (pause) ? 0 : 1f;
        menu_pausa.SetActive(true);
    }
    public void menu_principal1()
    {
        SceneManager.LoadScene(menu);
        Time.timeScale = (pause) ? 1 : 1f;
    }
    public void Reanudar() 
    {
        Time.timeScale = (pause) ? 1 : 1f;
        menu_pausa.SetActive(false);
    }

}
