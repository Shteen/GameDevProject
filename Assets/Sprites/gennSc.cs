using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gennSc : MonoBehaviour
{
  public GameObject Spawn;
  public GameObject Barrel1;
    void Start()
    {
      InvokeRepeating ("a",1,3.3f);
    }
    void Update()
    {

    }
    void a(){
      Spawn = Instantiate (Barrel1, transform.position,Quaternion.identity)as GameObject;
    }
    void OnCollisionEnter2D(Collision2D Coll){
        if(Coll.gameObject.tag=="Player"){
          Destroy(this);
        }
      }
}
