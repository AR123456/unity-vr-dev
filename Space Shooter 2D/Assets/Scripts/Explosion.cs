﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
      
        // this will be called when the Explosion starts so just destroy
        Destroy(this.gameObject, 3f);
               
    }

   
}
