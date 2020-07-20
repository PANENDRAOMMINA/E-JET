using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pod : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer sr;
    private bool _iscollided = false;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            _iscollided = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _iscollided = false;
        }
    }

    private void Update()
    {
        if(_iscollided)
        {
            sr.color = Color.red;
        }
        else
        {
            sr.color = Color.white;
        }
    }
    // Update is called once per frame


}
