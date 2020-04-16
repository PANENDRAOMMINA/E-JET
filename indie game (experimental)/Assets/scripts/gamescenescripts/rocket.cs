using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed;
   
    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
       
        
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
            scoreboard.instance.countscore();
            GameObject.Find("rocket spawner").GetComponent<spawner>().stopspawning = true;
            GameObject.Find("scorecounter").SetActive(false);
            GameObject.Find("Gameover").GetComponent<Animator>().enabled = true;
            GameObject.Find("scoreboard").GetComponent<scoreboard>().displayscore();
            
           
            
        }
       
    }
}
