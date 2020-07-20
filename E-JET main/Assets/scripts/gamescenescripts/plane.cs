using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public Rigidbody2D rb;
    private void Update()
    {
        rb.velocity = Vector2.left * 1;
    }
}
