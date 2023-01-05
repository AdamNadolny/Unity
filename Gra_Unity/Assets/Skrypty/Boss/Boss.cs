using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Boss : MonoBehaviour
{
    public Transform[] firePointList;

    public GameObject bulletPref;

    float bulletforce = 25f;
    float bulletforce1 = 10f;

    public bool canFire;
    public float timer = 0;
    float timeBetweenFiring = 100;
    bool ktory = false;
    int x1 = 0;

    public bool canFire1;
    public float timer1 = 0;
    float timeBetweenFiring1 = 70;
    int x = 0;
    bool GD = true;
    bool ktory2 = false;

    public bool canFire3;
    public float timer3 = 0;
    float timeBetweenFiring3 = 70;
    bool ktory3 = true;
    int x3 = 0;
    int losuj = 0;

    public GameObject sciana1;
    public GameObject sciana2;
    bool oslona = false;
    bool oslona2 = false;
    int speed = 1;




    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        if (oslona == true)
        {
            movOslona();
        }
        if (oslona2 == true)
        {
            movOslona2();
        }


        if (ktory == true)
        {
            if (!canFire)
            {

                if (timer > timeBetweenFiring)
                {
                    canFire = true;
                    timer = 0;
                }
                timer++;
            }

            if (canFire)
            {
                canFire = false;
                ShootAll();
                x1++;
                if (x1 == 3)
                {
                    ktory3 = false;
                    ktory2 = true;
                    ktory = false;
                    x1 = 0;
                }
            }

        }

        if (ktory2 == true)
        {
            if (!canFire1)
            {

                if (timer1 > timeBetweenFiring1)
                {
                    canFire1 = true;
                    timer1 = 0;
                }
                timer1++;
            }

            if (canFire1)
            {
                canFire1 = false;
                ShootPoJednej(x);
                if (x < 8 && GD == true)
                {
                    x++;
                    if (x == 8)
                    {
                        GD = false;
                        oslona = false;
                        oslona2 = true;
                    }
                }
                if (GD == false)
                {
                    x--;
                    if (x == -1)
                    {
                        ktory3 = true;
                        ktory2 = false;
                        ktory = false;
                        x = 0;
                        GD = true;
                    }
                }
            }

        }

        if (ktory3 == true)
        {
            if (!canFire3)
            {

                if (timer3 > timeBetweenFiring3)
                {
                    canFire3 = true;
                    timer3 = 0;
                }
                timer3++;
            }

            if (canFire3)
            {
                canFire3 = false;
                losuj = Random.Range(0, 9);
                ShootPoJednej(losuj);
                x3++;
                if (x3 == 40)
                {
                    oslona = true;
                    oslona2 = false;

                }
                if (x3 == 45)
                {
                    ktory3 = false;
                    ktory2 = false;
                    ktory = true;
                    x3 = 0;
                }
            }

        }

    }

    void ShootAll()
    {
        for (int i = 0; i < firePointList.Length; i++)
        {
            GameObject bullet = Instantiate(bulletPref, firePointList[i].position, firePointList[i].rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePointList[i].up * bulletforce, ForceMode2D.Impulse);
        }
    }

    void ShootPoJednej(int i)
    {
        GameObject bullet = Instantiate(bulletPref, firePointList[i].position, firePointList[i].rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePointList[i].up * bulletforce1, ForceMode2D.Impulse);
    }

    void movOslona()
    {
        sciana1.transform.Translate(Vector2.up * speed);
        sciana2.transform.Translate(-Vector2.up * speed);
        oslona = false;
    }

    void movOslona2()
    {
        sciana1.transform.Translate(-Vector2.up * speed);
        sciana2.transform.Translate(Vector2.up * speed);
        oslona2 = false;
    }

}