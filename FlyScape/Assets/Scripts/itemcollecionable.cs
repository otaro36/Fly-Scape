using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemcollecionable : MonoBehaviour
{
    public manageritem manager;
    
      private void Start()
      {
          manager = GameObject.Find("manager").GetComponent<manageritem>();        
      }
      private void OnTriggerEnter2D(Collider2D other)
      {
          transform.Rotate(new Vector2(15, 30) * Time.deltaTime);
          if (other.gameObject.name == "personaje_paloma")
          {
              Destroy(this.gameObject);
              manager.mensajes++;
          }
      }

}
