using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signal : MonoBehaviour
{
    public float x, y;

    private void Awake()
    {
        x = transform.position.x;
        y = transform.position.y;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="round rocket")
        {
            FindObjectOfType<fireworks>().change_direction = true;
            FindObjectOfType<fireworks>().rotate = true;
        }
    }
}
