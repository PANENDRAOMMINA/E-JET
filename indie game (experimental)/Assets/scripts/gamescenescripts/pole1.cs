﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pole1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public bool moved;
    public static pole1 instance;
    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moved == true)
        {
            if (transform.position.y > 3.2)
            {
                rb.velocity = Vector2.down * 3f;
                
               

            }
            else
                rb.velocity = Vector2.down * 0f;
        }
        else
        {
            if (transform.position.y < 6.28)
            {
                rb.velocity = Vector2.up * 3f;

            }
            else
                rb.velocity = Vector2.up * 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            scoreboard.instance.countscore();
            GameObject.Find("rocket spawner").GetComponent<spawner>().stopspawning = true;
            GameObject.Find("scorecounter").SetActive(false);
            GameObject.Find("Gameover").GetComponent<Animator>().enabled = true;
            GameObject.Find("scoreboard").GetComponent<scoreboard>().displayscore();



        }
        if (col.gameObject.tag == "rocket")
        {
            Destroy(col.gameObject);
        }


    }
}