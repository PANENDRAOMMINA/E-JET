using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocket;
    public GameObject plat,plat2,plane;
    public Image Image; 
    public bool stopspawning=false;
    float y1, y2,y3,rtime=0;
    public int r=0;
    private float _time2=0;
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
        
        
        InvokeRepeating("spawnrockets", 2f, 1.35f);
    }
    void spawnrockets()
    {
        

        if (_time2 < 7 && stopspawning==false)
        {
            if((r==2||r==4||r==6||r==8||r==9||r==12||r==15||r==14)&&_time2==1)
            {
                pole1.instance.moved = true;
                Vector3 p = new Vector3(transform.position.x, 4.72f, 0);
                Instantiate(plane, p, Quaternion.identity);
            }
           /*if(r==0&&(_time2==1))
            {
                //pusher.instance.forcemove = true;
            }
           if(r==0&&(_time2==3))
            {
               // pusher.instance.forcemove = false;
            }*/
           
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
            Instantiate(rocket, v, Quaternion.identity);
            
            if((r==2||r==4||r==6||r==8||r==9||r==12||r==14)&&(_time2==6))
            {
                pole1.instance.moved = false;
            }
            _time2++;
        }
        else if (_time2 >= 7 && _time2<17 && stopspawning == false)
        {
           // pusher.instance.forcemove = false;
            if ((r == 3 || r == 5||r==9||r==12||r==15||r==18)&&_time2==7)
            {
                pole1.instance.moved = true;
            }
            if (_time2 % 2 != 0)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y2), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            else
            {

                Vector3 v = new Vector3(transform.position.x, Random.Range(y2, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if((_time2==16)&&(r==3||r==5||r==9||r==12||r==15||r==18))
            {
                pole1.instance.moved = false;
            }
            _time2++;
        }
        else if(_time2>=17&&_time2<29&& stopspawning==false)
        {
            if((r==1||r==4||r==7||r==9||r==13||r==15||r==18||r==19)&&_time2==17)
            {
                pole1.instance.moved = true;
            }
   
           if(_time2==18)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==20)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==22)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==24)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==26)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==28)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if ((r ==1||r==4||r==7||r==9||r==13||r==15||r==18||r==19)&&_time2==28)
            {
                pole1.instance.moved = false;
            }
            _time2++;
         
            
        }
        else if(_time2>=29&&_time2<36&&stopspawning==false)
        {
            if((r==2||r==4||r==13||r==8||r==11||r==15||r==16)&&_time2==29)
            {
                pole1.instance.moved = true;
            }
            
            if(_time2==30)
            {
                Vector3 v = new Vector3(transform.position.x, -4.04f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 31)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==32)
            {
                Vector3 v = new Vector3(transform.position.x, 3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==33)
            {
                Vector3 v = new Vector3(transform.position.x, -4.04f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==34)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==35)
            {
                Vector3 v = new Vector3(transform.position.x, 3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if ((r == 2 || r == 4 || r == 13 || r == 8 || r == 11 || r == 15 || r == 16) && _time2 == 35)
            {
                pole1.instance.moved = false;
            }


            _time2++;

        }
        else if(_time2==36)
        {
            
            InvokeRepeating("spawnrockets2", 1f, 0.5f);
            _time2++;
        }
       
        
    }
    void spawnrockets2()
    {
        if(_time2>=37&&stopspawning==false)
        {
            if(_time2==37)
            {
                Vector3 v = new Vector3(transform.position.x, -3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 38)
            {
                Vector3 v = new Vector3(transform.position.x, -3.03f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 39)
            {
                Vector3 v = new Vector3(transform.position.x, -1.89f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 40)
            {
                Vector3 v = new Vector3(transform.position.x, -1f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
           if(_time2==41)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
           if(_time2==44&&r>0)
            {
                if(r%2!=0)
                {
                    pusher.instance.forcemove = true;
                }
                else
                {
                    pole1.instance.moved = true;
                }
            }
            if(_time2==43)
            {
                Vector3 v = new Vector3(transform.position.x,3.98f , 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if(_time2==44)
            {
                Vector3 v = new Vector3(transform.position.x, 3.03f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
           
            if (_time2 == 45)
            {
                Vector3 v = new Vector3(transform.position.x, 2.00f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 46)
            {
                Vector3 v = new Vector3(transform.position.x, 1.34f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 47)
            {
                Vector3 v = new Vector3(transform.position.x, 0f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 47 && r > 0)
            {
                if (r % 2 != 0)
                {
                    pusher.instance.forcemove = false;
                }
                else
                {

                    pole1.instance.moved = false;
                }
            }
            if (_time2==48)
            {
                CancelInvoke("spawnrockets2");
                InvokeRepeating("spawnrock3",1f,1.35f);
            }
            _time2++;
        }
      
    }
    void spawnrock3()
    {
        plat.SetActive(true);
        platform.instance.move = true;
        
        if(_time2>=52&&_time2<60&&stopspawning == false)
        {
            if (_time2 % 2 != 0)
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
       
        if(_time2>=60)
        {
           
            platform.instance.move = false;
        }
        if(_time2>=63)
        {
            plat.SetActive(false);
        }
        if(_time2>=64&&(_time2==65||_time2==69||_time2==71)&&_time2<72 && stopspawning == false)
        {
            Instantiate(rocket,new Vector3(transform.position.x,Random.Range(y1,y3)), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x,Random.Range(y1,y3)), Quaternion.identity);
        }
        else if(_time2>=64&&(_time2==65||_time2==68)&&_time2<71 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3)), Quaternion.identity);
        }
        if(_time2==73 && stopspawning == false)
        {
            plat2.SetActive(true);
            platform2.instance.move = true;
        }
        if(_time2>=74&&_time2<77 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(-3.16f, y1)), Quaternion.identity);
        }
        if(_time2>=77 && stopspawning == false )
        {
            platform2.instance.move = false;
        }
        if(_time2>=79&&_time2<83 && stopspawning == false)
        {
            plat2.SetActive(false);
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3)), Quaternion.identity);
            if(_time2==81&&(r==2||r==3||r==6||r==9||r==11||r==12||r==14||r==15||r==19))
            {
                pusher.instance.forcemove = true;
            }

        }
        if (_time2 == 83 && (r == 2 || r == 3 || r == 6 || r == 9||r==11||r==12||r==14|r==15||r==19))
        {
            pusher.instance.forcemove = false;
        }

        if (_time2==83 && stopspawning == false)
        {
            danger.instance.activated = true;
            
        }
        if(_time2==86 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -4f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -3.19f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1.91f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.12f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2.0f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.99f), Quaternion.identity);
        }
        if(_time2==88 && stopspawning == false)
        {
            _time2 = 0;
            r++;
            CancelInvoke("spawnrock3");
           
        }
        _time2++;

    }
    



}
