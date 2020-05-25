using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spear : MonoBehaviour
{
    // Start is called before the first frame update

    public bool forcemove;
    public Rigidbody2D rb;
    public static spear instance;
    
    
    
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
        Debug.Log(transform.position.y);
    }
    
    void Update()
    {
        
        if(forcemove==true)
        {
            if(transform.position.y>2.35)
            {
                rb.velocity = -Vector2.up * 4.8f;
            }
            else
            {
                rb.velocity = -Vector2.up * 0f;
            }
        }
        else
        {
            if (transform.position.y < 9.3)
            {
                rb.velocity = Vector2.up * 4.8f;
            }
            else
                rb.velocity = Vector2.up * 0;
        }
        
    }
    void FixedUpdate()
    {
       
    }
   
    // Update is called once per frame
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Player")
        {
            Destroy(col.gameObject);
            scoreboard.instance.countscore();
            GameObject.Find("rocket spawner").GetComponent<spawner>().stopspawning = true;
            GameObject.Find("scorecounter").SetActive(false);
            GameObject.Find("Gameover").GetComponent<Animator>().enabled = true;
            GameObject.Find("scoreboard").GetComponent<scoreboard>().displayscore();
            audiomanager.instance.play("gameover");
            audiomanager.instance.stop("bg music");
            
        }
        if(col.gameObject.tag=="rocket")
        {
            Destroy(col.gameObject);
        }
       
       
    }
}
