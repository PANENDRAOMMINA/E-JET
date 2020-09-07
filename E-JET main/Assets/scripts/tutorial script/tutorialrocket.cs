using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialrocket : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed;
    public static tutorialrocket instance;
    private Animator anim;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (instance == null)
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
        rb.velocity = Vector2.left * speed;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(2);
           
        }

    }
}
