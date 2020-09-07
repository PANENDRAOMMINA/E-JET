using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pole1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public bool moved;
    public static pole1 instance;
    private Animator anim;
    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
        anim = GameObject.Find("Gameover").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moved == true)
        {
            if (transform.position.y > 7.03f)
            {
                rb.velocity = Vector2.down * 3f;
                
               

            }
            else
                rb.velocity = Vector2.down * 0f;
        }
        else
        {
            if (transform.position.y < 9.04f)
            {
                rb.velocity = Vector2.up * 3f;

            }
            else
                rb.velocity = Vector2.up * 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            GameObject.Find("rocket spawner").GetComponent<spawner>().stopspawning = true;
            GameObject.Find("scorecounter").SetActive(false);
            anim.SetBool("isgameover", true);
            audiomanager.instance.stop("bg sound");
            audiomanager.instance.play("gameover");
            pausescript.instance.ispaused = false;

        }
        if (col.gameObject.tag == "rocket")
        {
            Destroy(col.gameObject);
        }


    }
}
