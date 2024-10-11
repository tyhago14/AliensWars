using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet1Fire : MonoBehaviour {


    public float fireRate = 1f;
    float nextFire = 0f;
    public GameObject Enemybullet1;
    Vector3 bulletPos;

    void FixedUpdate()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            firebullet();
        }
    }


    void firebullet()
    {
        bulletPos = transform.position;
        bulletPos += new Vector3(0, -100, 0);
        bulletPos.z = -5f;
        Instantiate(Enemybullet1, bulletPos, Quaternion.identity);

    }
}
