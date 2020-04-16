using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecounter : MonoBehaviour
{
    // Start is called before the first frame update
    public static scorecounter instance;
     void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rocket")
        {
            scoreboard.instance.increaseunit();

        }
    }
    
        
    
}
