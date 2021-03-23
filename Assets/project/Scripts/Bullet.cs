﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public float lifeduration = 2f;

    private float lifeTimer;


    // Start is called before the first frame update
    void Start()
    {
        lifeTimer = lifeduration;  
    }

    // Update is called once per frame
    void Update()
    {
        //Make the bullet move
        transform.position += transform.forward * speed * Time.deltaTime;

        // check if the bullet should be destroyed.
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f) {
            Destroy(gameObject);
         }
    }
}
