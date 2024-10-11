using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {

    public float scroolSpeed;
    Vector2 starPos;
	// Use this for initialization
	void Start () {
        starPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newPos = Mathf.Repeat(Time.time * scroolSpeed, 4000);
        transform.position = starPos + Vector2.up * newPos;
	}
}
