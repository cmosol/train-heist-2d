﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTrain : MonoBehaviour
{

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
