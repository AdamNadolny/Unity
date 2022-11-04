using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3 : MonoBehaviour
{

    public float speed = 10.0f;
    public float speed_rotate = 20.0f;
    float way = 0;
    
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    void Update()
    {
        if (transform.position.x <= -10 && way == 0)
        {
            this.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            way = 1;
        }
        if (transform.position.z <= -10 && way == 1)
        {
            this.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            way = 2;
        }
        if (transform.position.x >= 0 && way == 2)
        {
            this.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            way = 3;
        }
        if (transform.position.z >= 0 && way == 3)
        {
            this.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            way = 0;
        }

        transform.position += -transform.right * speed * Time.deltaTime;

    }

}
