﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.enabled = false;
    }

    // Update is called once per frame
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && flashlight.enabled == false)
        {
            flashlight.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && flashlight.enabled == true)
        {
            flashlight.enabled = false;
        }
    }
}
