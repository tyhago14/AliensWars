using UnityEngine;
using System.Collections;

public class Moviment : MonoBehaviour
{
    public Vector3 realPos;
    private Vector3 tempPos;
    public int tempo;


    void Update()
    {
        if (transform.position != realPos)
        {
            transform.position = Vector3.Lerp(transform.position, realPos, Time.deltaTime * tempo);
        }

        if (Input.touchCount > 0 && (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Moved))
        {
            Vector3 fingerPos = Input.GetTouch(0).position;
            tempPos = fingerPos;
            tempPos.z = 10;
            realPos = Camera.main.ScreenToWorldPoint(tempPos);
            realPos.z = -200;
            Debug.Log("Saltou");
        }


    }


}