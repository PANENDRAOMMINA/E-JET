using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundrocketremover : MonoBehaviour
{
    public GameObject parent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="round rocket")
        {
            Destroy(parent);
        }
    }
}
