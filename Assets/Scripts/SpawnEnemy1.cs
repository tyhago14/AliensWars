using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy1 : MonoBehaviour {

    public GameObject enemy1;
    public float delayTimer = 1f;
    private float timer;


	// Use this for initialization
	void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 enemy1Pos = new Vector3(Random.Range(-550f, 550f), transform.position.y, transform.position.z);
            Instantiate(enemy1, enemy1Pos, transform.rotation);
            timer = delayTimer;
        }
    }
}
