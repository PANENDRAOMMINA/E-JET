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
            GameObject.Find("rocket spawner").GetComponent<spawner>().stopspawning = true;
            GameObject.Find("Gameover").GetComponent<Animator>().enabled = true;
            audiomanager.instance.stop("bg music");
            audiomanager.instance.play("gameover");
            pausescript.instance.ispaused = false;


        }
       
    }
}
