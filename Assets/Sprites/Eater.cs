using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eater : MonoBehaviour
{
  void Update()
     {

     }
    void OnTriggerEnter2D(Collider2D kain){
      if(kain.gameObject.tag=="Respawn"){
         Destroy(kain.gameObject);
      }
    }
}
