﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;
 
 

    // Start is called before the first frame update
    void Start()
    {
        // define starting position of cube Y of 5.73 looks like top of screen
        transform.position = new Vector3(0, 5.75f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // move down at rate of 4 meters per second - use deltatime, not time 
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        //when it moves down the full lentgth of the screen, re spawn it at the top with a new random x position - this saves the step of distroing it if it drops off screen
        // bottom 0f screen -5f
        if (transform.position.y <= -5f)
        {
            // rand numb between 8 and - 8 - make it a float
            transform.position = new Vector3(Random.Range(-8f,8f), 5.75f, 0);
        }
    }
}
