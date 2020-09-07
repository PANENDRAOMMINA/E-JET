using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private void Update()
    {
        rb.velocity = Vector2.left * speed;
    }
}
