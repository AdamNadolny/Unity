using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //enemyspawn
    public Transform[] EnemyPoint;
    public GameObject EnemyPref;

    GameObject Zamke;
    // Start is called before the first frame update
    void Start()
    {
        Zamke = GameObject.Find("ZamykanieDrzwi");
    }


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zagadka")
        {
            for (int i = 0; i < EnemyPoint.Length; i++)
            {
                GameObject newEnemy = Instantiate(EnemyPref, EnemyPoint[i].position, EnemyPoint[i].rotation);
                Zamke.GetComponent<Zamykanie>().ilePrzeciwnikow += 1; 
            }
            Destroy(gameObject);
        }
    }
    
}
