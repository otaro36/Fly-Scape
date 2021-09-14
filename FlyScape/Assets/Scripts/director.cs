using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class director : MonoBehaviour
{
    public PlayableDirector director_;
    public Rigidbody2D per_quieto;
    public personajemovimiento quieto;
    public float limite_timelife;
    
    void Start()
    {
        director_ = GetComponent<PlayableDirector>();
        quieto = GameObject.Find("personaje_paloma").GetComponent<personajemovimiento>();
        per_quieto= GameObject.Find("personaje_paloma").GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (director_.time>=limite_timelife)
        {
            quieto.enabled = true;
            per_quieto.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="personaje")
        {

            director_.Play();
            quieto.enabled = false;
            per_quieto.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;     
        }
    }
}
