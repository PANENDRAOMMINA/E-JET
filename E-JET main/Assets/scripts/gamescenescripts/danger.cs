using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danger : MonoBehaviour
{
  
    private Animator anim;
    public bool activated=false;
    private float time=0;
    public static danger instance;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(activated)
        {
            if(time>0&&time<3)
            {
                anim.SetBool("danger", true);
            }
            if(time>4&&time<5)
            {
                anim.SetBool("danger", false);
            }
            if(time>5)
            {
                activated = false;
                time = 0;
            }
            time += 1 * Time.deltaTime;
        }
        

    }
}
