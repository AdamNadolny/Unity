using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkSpeed : MonoBehaviour
{

    GameObject gracz;
    // Start is called before the first frame update
    void Start()
    {
        gracz = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Zagadka")
        {
            if(gracz.GetComponent<Strzelanie>().timeBetweenFiring >= 1) 
            {
                gracz.GetComponent<Strzelanie>().timeBetweenFiring -= 50;
                if(gracz.GetComponent<Strzelanie>().timeBetweenFiring <= 0)
                {
                    gracz.GetComponent<Strzelanie>().timeBetweenFiring = 2;
                }
            }
            Destroy(gameObject);
        }

    }
}