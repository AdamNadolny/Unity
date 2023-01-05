using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zamykanie : MonoBehaviour
{
    public GameObject Drzwi1_GD;
    public GameObject Drzwi2_GD2;
    public GameObject Drzwi3_GD3;
    public GameObject Drzwi4_PL;
    public GameObject Drzwi5_PL2;
    public GameObject Drzwi6_PL3;
    public GameObject Drzwi7_PL4;
    public GameObject Drzwi8_PL5;
    public int ilePrzeciwnikow = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ilePrzeciwnikow > 0)
        {
            Drzwi1_GD.GetComponent<BoxCollider2D>().isTrigger = false;
            Drzwi1_GD.GetComponent<Drzwi>().czy_mozna = false;
            
        }
        else
        {
            Drzwi1_GD.GetComponent<BoxCollider2D>().isTrigger = true;
            Drzwi1_GD.GetComponent<Drzwi>().czy_mozna = true;
            
        }

        if (ilePrzeciwnikow > 0)
        {
            Drzwi2_GD2.GetComponent<BoxCollider2D>().isTrigger = false;
            
            Drzwi2_GD2.GetComponent<Drzwi>().czy_mozna = false;
        }
        else
        {
            Drzwi2_GD2.GetComponent<BoxCollider2D>().isTrigger = true;
            
            Drzwi2_GD2.GetComponent<Drzwi>().czy_mozna = true;
        }

        if (ilePrzeciwnikow > 0)
        {
            Drzwi3_GD3.GetComponent<BoxCollider2D>().isTrigger = false;

            Drzwi3_GD3.GetComponent<Drzwi>().czy_mozna = false;
        }
        else
        {
            Drzwi3_GD3.GetComponent<BoxCollider2D>().isTrigger = true;

            Drzwi3_GD3.GetComponent<Drzwi>().czy_mozna = true;
        }

        if (ilePrzeciwnikow > 0)
        {
            Drzwi4_PL.GetComponent<BoxCollider2D>().isTrigger = false;
            Drzwi4_PL.GetComponent<Drzwi2>().czy_mozna = false;

        }
        else
        {
            Drzwi4_PL.GetComponent<BoxCollider2D>().isTrigger = true;
            Drzwi4_PL.GetComponent<Drzwi2>().czy_mozna = true;

        }

        if(ilePrzeciwnikow > 0)
        {
            Drzwi5_PL2.GetComponent<BoxCollider2D>().isTrigger = false;
            Drzwi5_PL2.GetComponent<Drzwi2>().czy_mozna = false;

        }
        else
        {
            Drzwi5_PL2.GetComponent<BoxCollider2D>().isTrigger = true;
            Drzwi5_PL2.GetComponent<Drzwi2>().czy_mozna = true;

        }

        if (ilePrzeciwnikow > 0)
        {
            Drzwi6_PL3.GetComponent<BoxCollider2D>().isTrigger = false;
            Drzwi6_PL3.GetComponent<Drzwi2>().czy_mozna = false;

        }
        else
        {
            Drzwi6_PL3.GetComponent<BoxCollider2D>().isTrigger = true;
            Drzwi6_PL3.GetComponent<Drzwi2>().czy_mozna = true;

        }

        if (ilePrzeciwnikow > 0)
        {
            Drzwi7_PL4.GetComponent<BoxCollider2D>().isTrigger = false;
            Drzwi7_PL4.GetComponent<Drzwi2>().czy_mozna = false;

        }
        else
        {
            Drzwi7_PL4.GetComponent<BoxCollider2D>().isTrigger = true;
            Drzwi7_PL4.GetComponent<Drzwi2>().czy_mozna = true;

        }

        if (ilePrzeciwnikow > 0)
        {
            Drzwi8_PL5.GetComponent<BoxCollider2D>().isTrigger = false;
            Drzwi8_PL5.GetComponent<Drzwi2>().czy_mozna = false;

        }
        else
        {
            Drzwi8_PL5.GetComponent<BoxCollider2D>().isTrigger = true;
            Drzwi8_PL5.GetComponent<Drzwi2>().czy_mozna = true;

        }
    }
}
