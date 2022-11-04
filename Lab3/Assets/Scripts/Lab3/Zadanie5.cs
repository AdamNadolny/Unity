using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    int rand;
    int[] table(int a)
    {
        int[] tab = new int[a];
        int czy;
        int licz = 0;
        while(licz != a)
        {
            rand = Random.Range(-5, 6);
            czy = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (rand == tab[i])
                {
                    czy = 1;
                }
            }
            if(czy == 0)
            {
                tab[licz] = rand;
                licz++;
            }
        }
        return tab;
    }

    void Start()
    {
        int[] tabb = table(10);
        int[] tabb2 = table(10);
        for (int x = 0; x < width; ++x)
        {
            Instantiate(block, new Vector3(tabb[x], 2, tabb2[x]), Quaternion.identity);
        }
    }
    void Update()
    {

    }
}
