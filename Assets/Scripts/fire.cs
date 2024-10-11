using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {

    public GameObject bullet1;
    Vector3 bulletPos;
    public float fireRate = 1f;
    float nextFire = 0f;

	void FixedUpdate () {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            firebullet();
        }
    }

    void firebullet()
    {
        bulletPos = transform.position;
        bulletPos += new Vector3(0, 210, 0);
        bulletPos.z = -5f;
        Instantiate(bullet1, bulletPos, Quaternion.identity);

    }


}
