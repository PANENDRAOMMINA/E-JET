﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remover : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D edge;
     void Awake()
    {
        edge = GetComponent<BoxCollider2D>();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="rocket")
        {
            Destroy(col.gameObject);
        }
    }
}