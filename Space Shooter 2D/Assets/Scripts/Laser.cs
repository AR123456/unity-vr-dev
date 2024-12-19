﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;
     
    void Update()
    {
         transform.Translate(Vector3.up*_speed*Time.deltaTime);
        if (transform.position.y > 8f)
        {
            // if this object has a parent distroy it too
            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
 