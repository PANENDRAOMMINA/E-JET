using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charger : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool moved;
    public static charger instance;
    public void Awake()
    {
        if (instance == null)
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
            if (transform.position.y < -5.2f)
            {
                rb.velocity = Vector2.up * 3f;
            }
            else
                rb.velocity = Vector2.up * 0f;
        }
        else
        {
            if (transform.position.y > -6.32f)
            {
                rb.velocity = Vector2.down * 3f;
            }
            else
                rb.velocity = Vector2.down * 0f;
        }
    }
}
