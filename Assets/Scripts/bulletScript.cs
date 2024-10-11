using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {


    float velX = 0;
    public float velY = 1600f;
    Rigidbody2D rb;
    public GameObject explosionAnim;


    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(velX, velY);
        Destroy(gameObject, 2f);
    }


 public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Enemy1")
        {
            PlayExplosion2();
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

    }

    void PlayExplosion2()
    {
        GameObject explosionPos = (GameObject)Instantiate(explosionAnim);

        explosionPos.transform.position = transform.position + new Vector3(0f,100f,0f) ;
    }

}


