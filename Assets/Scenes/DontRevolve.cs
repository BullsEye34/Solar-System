﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontRevolve : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Transform sun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.position, Vector3.up, Time.deltaTime * -speed); 
    }
}
