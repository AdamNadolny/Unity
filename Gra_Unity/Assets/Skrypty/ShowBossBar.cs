using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBossBar : MonoBehaviour
{
    public GameObject sciana1;
    public GameObject sciana1PO;
    public GameObject sciana1PRZED;
    GameObject zamyk;
    int speed = 557;
    public GameObject bosshp;

    // Start is called before the first frame update
    private void Start()
    {
        zamyk = GameObject.Find("ZamykanieDrzwi");
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sciana1.transform.position = Vector2.MoveTowards(sciana1.transform.position, sciana1PO.transform.position, speed);
            zamyk.GetComponent<Zamykanie>().ilePrzeciwnikow = 1;
        }

    }
}
