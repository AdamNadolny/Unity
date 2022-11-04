using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{

    public float speed = 10.0f;
    public float way = 0;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.x <= 0)
        {
            way = 1;
        }
        if (transform.position.x >= 10)
        {
            way = -1;
        }
        transform.Translate(transform.right * way * speed * Time.deltaTime);
    }

}
