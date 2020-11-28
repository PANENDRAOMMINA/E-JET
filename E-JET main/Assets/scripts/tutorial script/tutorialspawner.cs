using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tutorialspawner : MonoBehaviour
{
    private float time=0;
    public GameObject rocket;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Image panel;
    private bool rocketsent=true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 1 && time < 2)
        {
            var panelalpha = panel.color;
            panelalpha.a -= Time.deltaTime;
            panel.color = panelalpha;

        }
        if(time>3&&time<6)
        {
             text1.gameObject.SetActive(true);
        }
        if(time>6&&time<7)
        {
            text1.gameObject.SetActive(false);

        }
        if(time>7&&time<10)
        {
            text2.gameObject.SetActive(true);
        }
        if(time>10f&&time<12f)
        {
            text2.gameObject.SetActive(false);
        }  
        if(time>12f&&time<16f)
        {
            text3.gameObject.SetActive(true);
        }
        if(time>16f&&time<17f)
        {
            text3.gameObject.SetActive(false);
        }
        if(time>17f&&time<18f)
        {
            text4.gameObject.SetActive(true);
           
        }
        if(time>18f&&time<19f)
        {
            if (rocketsent)
            {
                Instantiate(rocket, new Vector3(transform.position.x, 0.5f, 0), Quaternion.identity);
                rocketsent = false;
            }
        }
        if(time>20f&&time<21)
        {
            rocketsent = true;
            text4.gameObject.SetActive(false);
        }
        if(time>21&&time<24)
        {
            text5.gameObject.SetActive(true);
        }
        if(time>24&&time<25)
        {
            text5.gameObject.SetActive(false);
        }
        if(time>25&&time<27)
        {
            text6.gameObject.SetActive(true);
           if(time>26&&time<27)
            {
                if (rocketsent)
                {
                    Instantiate(rocket, new Vector3(transform.position.x, -2.41f, 0), Quaternion.identity);
                    rocketsent = false;
                }
            }
        }
        if(time>27&&time<29)
        {
            text6.gameObject.SetActive(false);
            text7.gameObject.SetActive(true);
        }
        if(time>30&&time<31)
        {
            text7.gameObject.SetActive(false);
            if (rocketsent)
            {
                Instantiate(rocket, new Vector3(transform.position.x, Random.Range(3.3f, -2.45f), 0), Quaternion.identity);
                rocketsent=false;
            }
        }
        if(time>31&&time<32)
        {
            rocketsent = true;
        }
        if(time>32&&time<33)
        {
            if (rocketsent)
            {
                Instantiate(rocket, new Vector3(transform.position.x, Random.Range(3.3f, -2.45f), 0), Quaternion.identity);
                rocketsent = false;
            }
        }
        if (time > 33 && time < 34)
        {
            rocketsent = true;
        }
        if (time > 34 && time < 35)
        {
            if (rocketsent)
            {
                Instantiate(rocket, new Vector3(transform.position.x, -2.41f, 0), Quaternion.identity);
                rocketsent = false;
            }
        }
        if (time > 35 && time < 36)
        {
            rocketsent = true;
        }
        if (time>36&&time<40)
        {
            text8.gameObject.SetActive(true);
        }
        if(time>40&&time<44)
        {
            text8.gameObject.SetActive(false);
            text9.gameObject.SetActive(true);
        }
        if(time>45)
        {
            SceneManager.LoadScene(4);
        }
         time += Time.deltaTime;
    }
}
