using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovment : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    float speed = 4;
    float radius = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(waypoints[current].transform.position, transform.position) < radius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}