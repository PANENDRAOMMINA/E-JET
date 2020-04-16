using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocket;
    public Camera cam;
    public float time1;
    public bool stopspawning=false;
    float y1, y2,y3,rtime=0;
    int z,r;
    private int time2=0;
    private bool started=false;
    public static spawner instance;
    

     void Awake()
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
            
        StartCoroutine(spawnrockets(1f));
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rtime = rtime + Time.deltaTime;
      
    }
    IEnumerator spawnrockets(float time)
    {
        if (started == false )
        {
            yield return new WaitForSecondsRealtime(time);
            started = true;
        }
        else if (started == true)
        {
            yield return new WaitForSecondsRealtime(0);
        }
    
        r = Random.Range(0, 2);
        
       
       

        if(stopspawning==false )
        {
            if(r==0)
            {
               
                StartCoroutine(spawnrocketsstall(time1));
            }
            else if(r==1)
            {
               
                StartCoroutine(spawnrock1(time1));
            }
            
        }
       
       

    }
    IEnumerator spawnrocketsstall(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        if(time2<10&&stopspawning==false)
        {
            
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
            Instantiate(rocket, v, Quaternion.identity);
            time2++;
            StartCoroutine(spawnrocketsstall(time));
        }
        else
        {
            StartCoroutine(spawnrockets(time));
            time2 = 0;
        }
        

    }
    IEnumerator spawnrock1(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        if(time2<10&&stopspawning==false)
        {
            if(time2%2!=0)
            {
               
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y2), 0);
                Instantiate(rocket, v, Quaternion.identity);
                StartCoroutine(spawnrock1(time1));
            }
            else
            {
               
                Vector3 v = new Vector3(transform.position.x, Random.Range(y2, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
                StartCoroutine(spawnrock1(time1));
            }
            time2++;
        }
        else
        {
            StartCoroutine(spawnrockets(time1));
            time2 = 0;
        }
        
    }



}
