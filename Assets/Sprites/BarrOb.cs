using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrOb : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        transform.position-= new Vector3 (3f*Time.deltaTime,0,0);
    }
    void OnCollisionEnter2D(Collision2D Coll){
      if(Coll.gameObject.tag=="Eatt"){
        Destroy(this);
      }

       if(Coll.gameObject.tag=="Player"){
        Destroy(this.gameObject);
      }
    }

    
}
