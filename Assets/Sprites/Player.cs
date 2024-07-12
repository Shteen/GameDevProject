using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public gmScreen gmScreen;
    public winScreen winScreen;
    public bool fall;
    public bool yeet;
    private const float Speed = 10f;
    public int score;
    void Start()
    {
        yeet = false;
    }
    void Update()
    {
        HandleMovement();
        if(Input.GetKey(KeyCode.Space)  && yeet==false){
          GetComponent<Rigidbody2D>().velocity = new Vector3 (0,14,0);
          yeet=true;
        }

        if (Input.GetKey(KeyCode.S)){
          fall = true;
        }
        else{
          fall = false;
        }


        if(ScoreManager.instance.yass == 5)
        {
          winScreen.Setup(score);
        }

    }
    private void HandleMovement(){
      float moveX = 0f;
      float moveY = 0f;
      if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
      {
        moveX = -1f;
      }
      if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
      {
        moveX = +1f;
      }
      Vector3 moveDir = new Vector3(moveX,moveY).normalized;
      transform.position += moveDir * Speed * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D Coll){
      if(Coll.gameObject.tag=="Finish"){
        yeet= false;
      }

      if(Coll.gameObject.tag=="Respawn"){
       
       gmScreen.Setup(score);
       Destroy(this);
       
      }
      if(Coll.gameObject.tag=="End"){
        Debug.Log("Finish!!");
      }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
      if(col.transform.tag=="End"){
       ScoreManager.instance.AddScore();
       Destroy(col.gameObject);
      }
    }

     
    

}
