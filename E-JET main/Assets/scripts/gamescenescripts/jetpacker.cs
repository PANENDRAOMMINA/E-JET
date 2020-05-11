using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jetpacker : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private bool isgrounded;
    public Transform freepos;
    public float checkRadius;
    public LayerMask whatisground;
    public GameObject burst,pod;
    [SerializeField]
    private float jumpforce;
    private ParticleSystem particles;
    public Image fill;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        particles = GetComponent<ParticleSystem>();
        fill = GameObject.Find("loadingfill").GetComponent<Image>();
    }
    void Start()
    {
        admanager.instance.RequestBanner();
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics2D.OverlapCircle(freepos.position, checkRadius, whatisground);
        
        
        if(isgrounded==true&&Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up*jumpforce;
            burst.SetActive(true);
            loadingbar.instance.decreasefuel();
            pod.GetComponent<Animator>().SetBool("ischarging", true);


        }
        else if (isgrounded==true)
        {
            loadingbar.instance.increasefuel();
            pod.GetComponent<Animator>().SetBool("ischarging", true);
            

        }
        if(Input.GetMouseButton(0)&&fill.fillAmount>0)
        {
            rb.velocity = Vector2.up * jumpforce;
            burst.SetActive(true);
            loadingbar.instance.decreasefuel();
            pod.GetComponent<Animator>().SetBool("ischarging", false);


        }
        else
        {
            burst.SetActive(false);
            rb.velocity = -Vector2.up * jumpforce;
            pod.GetComponent<Animator>().SetBool("ischarging", false);

        }
        
        
    }
}
