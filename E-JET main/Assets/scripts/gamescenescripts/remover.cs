using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remover : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D edge;
    private Animator anim;
     void Awake()
    {
        edge = GetComponent<BoxCollider2D>();
        
    }
    void Start()
    {
        anim = GameObject.Find("Gameover").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="rocket")
        {
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag=="Player")
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
