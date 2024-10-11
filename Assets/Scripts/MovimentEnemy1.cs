using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentEnemy1 : MonoBehaviour {

    public float speed = 5f;

	void Start () {
		
	}

	void Update () {
        transform.Translate(new Vector3(0,-1,0) * speed * Time.deltaTime);
        Destroy(gameObject, 5f);
	}
}
