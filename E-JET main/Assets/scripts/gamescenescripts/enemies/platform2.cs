using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public static platform2 instance;
    public bool move;
   
    
    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }

        rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            if (transform.position.x > 0)
            {
                rb.velocity = Vector2.left * 4f;
              
            }
            else
            {
                rb.velocity = Vector2.left * 0;
            }
        }
        if(move==false)
            {
                if (transform.position.x < 5.9)
                {
                    rb.velocity = Vector2.right * 4f;
                }
                else
                {
                    rb.velocity = Vector2.right * 0;
                }
            }

    }
}
