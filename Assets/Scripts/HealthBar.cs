using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Sprite[] hp;
    public GameObject player;
    private Collision OtherScript;
    private int hpNumber;

    private void Start()
    {
        OtherScript = player.GetComponent<Collision>();
        hpNumber = OtherScript.lifes;
    }


    void Update () {
        hpNumber = OtherScript.lifes;
        if(player == null)
        { this.GetComponent<SpriteRenderer>().sprite = hp[0]; }
        if (hpNumber == 10)
        { this.GetComponent<SpriteRenderer>().sprite = hp[10]; }
        if (hpNumber == 9)
        { this.GetComponent<SpriteRenderer>().sprite = hp[9]; }
        if (hpNumber == 8)
        { this.GetComponent<SpriteRenderer>().sprite = hp[8]; }
        if (hpNumber == 7)
        { this.GetComponent<SpriteRenderer>().sprite = hp[7]; }
        if (hpNumber == 6)
        { this.GetComponent<SpriteRenderer>().sprite = hp[6]; }
        if (hpNumber == 5)
        { this.GetComponent<SpriteRenderer>().sprite = hp[5]; }
        if (hpNumber == 4)
        { this.GetComponent<SpriteRenderer>().sprite = hp[4]; }
        if (hpNumber == 3)
        { this.GetComponent<SpriteRenderer>().sprite = hp[3]; }
        if (hpNumber == 2)
        { this.GetComponent<SpriteRenderer>().sprite = hp[2]; }
        if (hpNumber == 1)
        { this.GetComponent<SpriteRenderer>().sprite = hp[1]; }
        if (hpNumber == 0)
        { this.GetComponent<SpriteRenderer>().sprite = hp[0]; }
    }
}
