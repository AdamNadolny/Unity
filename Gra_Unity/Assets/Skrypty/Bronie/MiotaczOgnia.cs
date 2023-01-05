using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiotaczOgnia : MonoBehaviour
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
        if (collision.tag == "Player")
        {
            gracz.GetComponent<Strzelanie>().dmg = 1;
            gracz.GetComponent<Strzelanie>().timeBetweenFiring = 1;
            Destroy(gameObject);
        }

    }
}
