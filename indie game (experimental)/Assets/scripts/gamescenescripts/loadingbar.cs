using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadingbar : MonoBehaviour
{
    // Start is called before the first frame update
    public static loadingbar instance;
    
    public Image fill;
    public float speed;
    public float speed1;
    public bool gameover=false;
     void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        
    }
    void Start()
    {
        fill = GameObject.Find("loadingfill").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void decreasefuel()
    {
        fill.fillAmount -= Time.deltaTime * speed;
    }
    public void increasefuel()
    {
        fill.fillAmount += Time.deltaTime * speed1;
    }
   
}
