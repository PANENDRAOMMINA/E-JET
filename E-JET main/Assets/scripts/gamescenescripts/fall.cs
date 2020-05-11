using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    // Start is called before the first frame update
    public static rocket instance;
   
    
    
    void Awake()
    {
      
       
        
       
        
    }
    void Start()
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
            
           
            
        }
       
    }
}
