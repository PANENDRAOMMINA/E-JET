using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed;
    public static rocket instance;
    private Animator anim;
   
    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if(instance==null)
        {
            instance = this;
        }
        anim = GameObject.Find("Gameover").GetComponent<Animator>();
        
    }
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.left * speed;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Player")
        {
            Destroy(col.gameObject);
            GameObject.Find("rocket spawner").GetComponent<spawner>().stopspawning = true;
            anim.SetBool("isgameover", true);
            audiomanager.instance.stop("bg sound");
            audiomanager.instance.play("gameover");
            pausescript.instance.ispaused = false;
        }
       
    }
    
}
