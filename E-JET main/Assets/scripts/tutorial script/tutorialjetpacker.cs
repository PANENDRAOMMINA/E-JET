using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialjetpacker : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isgrounded;
    public bool ispushed = false;
    public Transform freepos;
    public float checkRadius;
    public LayerMask whatisground;
    public GameObject burst;
    [SerializeField]
    private float jumpforce;
    private ParticleSystem particles;
    public Image fill;

    public static tutorialjetpacker instance;
    void Awake()
    {
         rb = GetComponent<Rigidbody2D>();
        particles = GetComponent<ParticleSystem>();
        fill = GameObject.Find("loadingfill").GetComponent<Image>();
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
        isgrounded = Physics2D.OverlapCircle(freepos.position, checkRadius, whatisground);


        if (isgrounded == true && Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpforce;
            burst.SetActive(true);
            loadingbar.instance.decreasefuel();
        }
        else if (isgrounded == true)
        {
            loadingbar.instance.increasefuel();
        }
        if (Input.GetMouseButton(0) && fill.fillAmount > 0)
        {
            rb.velocity = Vector2.up * jumpforce;
            burst.SetActive(true);
            loadingbar.instance.decreasefuel();
        }
        else
        {
            burst.SetActive(false);
            rb.velocity = -Vector2.up * jumpforce;
        }
        if (ispushed)
        {
            rb.AddForce(new Vector2(-3f, 0f), ForceMode2D.Impulse);
        }


    }
}
