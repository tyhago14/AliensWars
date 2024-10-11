using UnityEngine;

public class Collision : MonoBehaviour {

    public GameObject explosionAnim;
    public int lifes = 10;
    public int DamageEny1 = 3;
   

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Enemy1")
        {
            lifes = 0;
            Destroy(collision.gameObject);
            PlayExplosion();
            FindObjectOfType<GameManager>().EndGame();  
        }
        if (collision.collider.tag == "Enemybullet1")
        {
            lifes -= DamageEny1;
            if(lifes <= 0)
            {
                Destroy(collision.gameObject);
                PlayExplosion();
                FindObjectOfType<GameManager>().EndGame();
            }
            else
            {

                Destroy(collision.gameObject);

            }
         }

    }

    public void PlayExplosion()
    {
        GameObject explosionPos = (GameObject)Instantiate(explosionAnim);
        explosionPos.transform.position = transform.position;

    }

}




