﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocket;
    public GameObject plat,plat2,warn;
    public bool stopspawning=false;
    float y1, y2,y3,rtime=0;
    int z=1;
    private float time2=0;
    private bool started=false;
    public static spawner instance;
    

     public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }

        y1 = 4.02f;
        y2 = -0.02f;
        y3 = -3.98f;
    }
    void Start()
    {
        StartCoroutine(spawn(0));
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rtime = rtime + Time.deltaTime;
        
       
    }

    IEnumerator spawn(float time)
    {
        yield return new WaitForSecondsRealtime(0f);
        
        
            InvokeRepeating("spawnrockets", 1f, 1.2f);
       
      


    }
    void spawnrockets()
    {
        

        if (time2 < 7 && stopspawning==false)
        {
            
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
            Instantiate(rocket, v, Quaternion.identity);
            time2++;
        }
        else if (time2 >= 7 && time2<17 && stopspawning == false)
        {
            if (time2 % 2 != 0)
            {
                

                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y2), 0);
                Instantiate(rocket, v, Quaternion.identity);
               
            }
            else
            {

                Vector3 v = new Vector3(transform.position.x, Random.Range(y2, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
               
            }
            time2++;
        }
        else if(time2>=17&&time2<29&& stopspawning==false)
        {
           if(time2==18)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==20)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==22)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==24)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==26)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==28)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            time2++;
            
        }
        else if(time2>=29&&time2<36&&stopspawning==false)
        {
            if(time2==30)
            {
                Vector3 v = new Vector3(transform.position.x, -4.04f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (time2 == 31)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==32)
            {
                Vector3 v = new Vector3(transform.position.x, 3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==33)
            {
                Vector3 v = new Vector3(transform.position.x, -4.04f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==34)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==35)
            {
                Vector3 v = new Vector3(transform.position.x, 3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            time2++;

        }
        else if(time2==36)
        {
            
            InvokeRepeating("spawnrockets2", 1f, 0.5f);
            time2++;
        }
        
    }
    void spawnrockets2()
    {
        if(time2>=37&&stopspawning==false)
        {
            if(time2==37)
            {
                Vector3 v = new Vector3(transform.position.x, -3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (time2 == 38)
            {
                Vector3 v = new Vector3(transform.position.x, -3.03f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (time2 == 39)
            {
                Vector3 v = new Vector3(transform.position.x, -1.89f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (time2 == 40)
            {
                Vector3 v = new Vector3(transform.position.x, -1f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
           if(time2==41)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==43)
            {
                Vector3 v = new Vector3(transform.position.x,3.98f , 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==44)
            {
                Vector3 v = new Vector3(transform.position.x, 3.03f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (time2 == 45)
            {
                Vector3 v = new Vector3(transform.position.x, 2.00f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (time2 == 46)
            {
                Vector3 v = new Vector3(transform.position.x, 1.34f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (time2 == 47)
            {
                Vector3 v = new Vector3(transform.position.x, 0f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(time2==48)
            {
                CancelInvoke("spawnrockets2");
                InvokeRepeating("spawnrock3",1f,1f);
            }
            time2++;
        }
      
    }
    void spawnrock3()
    {
        plat.SetActive(true);
        platform.instance.move = true;
        
        if(time2>=52&&time2<60&&stopspawning == false)
        {
            if (time2 % 2 != 0)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(0.63f,4.11f), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            else
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(-0.83f, -3.98f), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
        }
       
        if(time2>=60)
        {
           
            platform.instance.move = false;

        }
        if(time2>=64)
        {
            plat.SetActive(false);
        }
        if(time2>=65&&(time2==65||time2==69||time2==71)&&time2<72 && stopspawning == false)
        {
            Instantiate(rocket,new Vector3(transform.position.x,Random.Range(y1,y3)), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x,Random.Range(y1,y3)), Quaternion.identity);
        }
        else if(time2>=65&&(time2==67||time2==68)&&time2<71 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3)), Quaternion.identity);
        }
        if(time2==73 && stopspawning == false)
        {
            plat2.SetActive(true);
            platform2.instance.move = true;
        }
        if(time2>=74&&time2<77 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(-3.16f, y1)), Quaternion.identity);
        }
        if(time2>=77 && stopspawning == false)
        {
            platform2.instance.move = false;
        }
        if(time2>=79&&time2<83 && stopspawning == false)
        {
            plat2.SetActive(false);
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3)), Quaternion.identity);

        }
        if(time2==83 && stopspawning == false)
        {
            warn.SetActive(true);
        }
        if(time2==85 && stopspawning == false)
        {
            warn.SetActive(false);
        }
        if(time2==86||time2==87 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -4f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -3.19f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1.91f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.12f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2.0f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.99f), Quaternion.identity);
        }
        if(time2==88 && stopspawning == false)
        {
            time2 = 0;
            CancelInvoke("spawnrock3");
        }
        time2++;

    }
    



}
