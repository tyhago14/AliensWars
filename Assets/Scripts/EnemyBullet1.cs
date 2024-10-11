using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet1 : MonoBehaviour {

    public float speed = 500f;
    public Transform target;
    Vector3 alvo;
    float angx;
    float angy;


    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").transform;
        alvo = target.position;
        angx = (transform.position.x - alvo.x) * -20;
        angy = (transform.position.y - alvo.y) * -20;
        alvo = new Vector3(angx, angy,-5f);
        Debug.Log(transform.position);
        Debug.Log(alvo);
    }



    void Update()
      {
        transform.position = Vector2.MoveTowards(transform.position, alvo, speed * Time.deltaTime);
        if(transform.position.x > 700f || transform.position.x < -700f || transform.position.y > 1200f || transform.position.y < -1200f )
        { Destroy(gameObject); }
 
      }
}
