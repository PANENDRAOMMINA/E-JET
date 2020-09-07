using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private float time=0,traveltime=0.2f;
    private Vector3 v;
    private float speed=12f;
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        anim = GameObject.Find("Gameover").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time<traveltime)
        {
            rb.velocity = Vector2.left*speed;
            rb.gravityScale = 0;
            anim.SetBool("wingsup", true);
        }
        if (time >traveltime&&time<0.4f)
            rb.velocity = Vector2.left * 0f;
        if(time>0.4&&time<1.2f)
        {
            anim.SetBool("wingsup", false);
            rb.gravityScale = 1;
        }
        if(time>1.2f)
        {
            time = 0;
            rb.gravityScale = 0;
            speed = 16f;
            traveltime = 0.38f;
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            GameObject.Find("rocket spawner").GetComponent<spawner>().stopspawning = true;
            GameObject.Find("scorecounter").SetActive(false);
            audiomanager.instance.stop("bg sound");
            audiomanager.instance.play("gameover");
            anim.SetBool("isgameover", true);
            pausescript.instance.ispaused = false;
        }

    }
}
