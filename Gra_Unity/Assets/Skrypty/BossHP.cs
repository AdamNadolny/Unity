using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour
{
    public GameObject sciana1;
    public GameObject sciana1PRZED;
    public GameObject sciana2;
    public GameObject sciana2PO;
    int maxHealth = 750;
    public int currentHealth;
    GameObject zamyk;
    GameObject gracz;
    int speed = 557;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        gracz = GameObject.Find("Player");
        zamyk = GameObject.Find("ZamykanieDrzwi");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            TakeDamage(gracz.GetComponent<Strzelanie>().dmg);
            if (currentHealth <= 0)
            {
                sciana1.transform.position = Vector2.MoveTowards(sciana1.transform.position, sciana1PRZED.transform.position, speed);
                sciana2.transform.position = Vector2.MoveTowards(sciana2.transform.position, sciana2PO.transform.position, speed);
                zamyk.GetComponent<Zamykanie>().ilePrzeciwnikow = 0;
                Destroy(gameObject);
            }
        }

    }
}

