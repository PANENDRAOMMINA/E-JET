using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireworks : MonoBehaviour
{
    //PARAMETERS
    public float angularSpeed = 60f;
    public float circleRad = 2f;
    public bool change_direction,rotate;
    public Animator anim;
   
    
    public float speed;
    //COMPONENTS
    public Vector2 fixedPoint;
    private Rigidbody2D rb;


    public float currentAngle;

    private void Awake()
    {
        fixedPoint = new Vector2(FindObjectOfType<signal>().x,FindObjectOfType<signal>().y+2);
        rb = GetComponent<Rigidbody2D>();
        anim = GameObject.Find("Gameover").GetComponent<Animator>();
    }

    void Start()
    {
        rotate = false;
        change_direction = false;   
    }
    void Update()
    {
        if(change_direction)
        {
            changerotation();
        }
        else
        {
            if (rotate)
            {
                rb.velocity = Vector2.left * speed;
            }
            else
            {
                rb.velocity = Vector2.right * speed;
            }
        }
    }
    public void changerotation()
    {
        currentAngle += angularSpeed * Time.deltaTime;
        float x = -Mathf.Sin(currentAngle);
        float y = -Mathf.Cos(currentAngle);
        Vector2 offset= new Vector2(x , y)*circleRad;
        transform.position = fixedPoint+offset;
        transform.rotation = Quaternion.Euler(0, 0,-currentAngle*60);
        if (currentAngle > circleRad+1)
        {
            currentAngle = 0;
            change_direction = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
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
