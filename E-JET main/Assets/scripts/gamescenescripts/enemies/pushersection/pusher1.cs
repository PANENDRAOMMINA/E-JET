using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class pusher1 : MonoBehaviour
{
    // Start is called before the first frame update

    public bool forcemove;
    public Rigidbody2D rb;
    public static pusher1 instance;
    private bool thrust = false;
    private float time = 0;

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
        time = 0;
        Debug.Log(transform.position.x);
    }


    private void Update()
    {
        if (forcemove == true)
        {
            if (time > 1 && time < 2.6f)
            {

                if (transform.position.x > 7.1f)
                {
                    rb.velocity = Vector2.left * 1.2f;
                }
                else
                {
                    rb.velocity = Vector2.left * 0f;
                }
                StartCoroutine(Waittime(1.2f));

                if (transform.position.x < 7.3f && thrust)
                {

                    if (transform.position.x > 3.1f)
                    {
                        rb.velocity = Vector2.left * 20f;
                    }
                    else
                    {
                        rb.velocity = Vector2.left * 0f;
                    }
                }
            }
            else if (time > 2.7f)
            {
                if (transform.position.x < 7.6f)
                {
                    rb.velocity = Vector2.right * 5.0f;
                }
                else
                {
                    rb.velocity = Vector2.right * 0f;
                    thrust = false;
                    forcemove = false;
                    time = 0;
                }
            }
            time = time + Time.deltaTime;
        }



    }
    void FixedUpdate()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            jetpacker.instance.ispushed = true;
        }
    }
    IEnumerator Waittime(float time)
    {
        if (!thrust)
        {
            yield return new WaitForSecondsRealtime(time);
            thrust = true;
        }

    }
}
