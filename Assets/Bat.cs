﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // The target marker.
    public GameObject target;

    // Angular speed in radians per sec.
    float speed;

    void Update()
    {

        Vector3 targetDir = GameObject.Find("Player").transform.position - transform.position;

        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);

        // Move our position a step closer to the target.
        transform.rotation = Quaternion.LookRotation(newDir);

        GetComponent<Rigidbody>().AddForce(GameObject.Find("Player").transform.position - transform.position - new Vector3(0,5,0));

    }

    private void OnTriggerEnter(Colli)
    {
            Debug.Log("Collided with enemy");

            if(--health<=0)
            {
                Destroy(this);
            }

    }
}