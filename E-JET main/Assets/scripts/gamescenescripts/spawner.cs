using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocket;
    public GameObject plat, plat2;
    //PUSHERS SECTION
    public GameObject Pusher1, Pusher2, Pusher3;
    //FAILY ROCKET SECTION
    public GameObject failyrocket;
    //ROUND ROCKET SECTION
    public GameObject roundaboutrocket;

    public Text scoretext;

    public bool stopspawning=false;
    float y1, y2,y3,rtime=0;
    public int r=0;
    public  float _time2=0;
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
        
    }

    IEnumerator spawn(float time)
    {
        yield return new WaitForSecondsRealtime(0f);
        
        // invoking first phase of enemies
        InvokeRepeating("spawnrockets", 2f, 1.35f);
    }
    //===========================================SPAWNING SET 1==================================================================================================
    //-----------------------------------SPAWN ROCKET TIME =1.35 SEC------------------------------------------------------------------------------
    //----------------------------------NUMBER OF ROCKETS= 29----------------------------------------------------------------------------------------------------
    void spawnrockets()
    {
        //ENTERING _time2 =0
        // set 1-----------------------------------------------------------------------------------------------------------------------------
        if (_time2 < 7 && stopspawning == false)
        { 
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
            Instantiate(rocket, v, Quaternion.identity);
            _time2++;
        }
        // set 2-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (  _time2 >= 7 && _time2 < 17 && stopspawning == false)
        { 
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
            _time2++;
           
        }
        // set 3---------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (_time2 >= 17 && _time2 < 29 && stopspawning == false)
        {
            if (_time2 == 18)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 20)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 22)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 24)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 26)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 28)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            _time2++;
        }
        // set 4-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        else if (_time2 >= 29 && _time2 < 36 && stopspawning == false)
        {

            if (_time2 == 30)
            {
                Vector3 v = new Vector3(transform.position.x, -4.04f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 31)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 32)
            {
                Vector3 v = new Vector3(transform.position.x, 3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 33)
            {
                Vector3 v = new Vector3(transform.position.x, -4.04f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 34)
            {
                Vector3 v = new Vector3(transform.position.x, 0, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (_time2 == 35)
            {
                Vector3 v = new Vector3(transform.position.x, 3.98f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
            if (  _time2 == 35)
            {
                pole1.instance.moved = false;
            }


            _time2++;

        }
        else if (_time2 == 36)
        {

            InvokeRepeating("spawnrockets2", 1f, 0.5f);
            _time2++;
          
        }
       
        
    }
    //===================================================================SPAWNING SET 2==================================================================================================
    //----------------------------------------------------------   SPAWN ROCKET TIME =0.5 SEC   -------------------------------------------------------------------------------------------------------
    //------------------------------------------------------------  NUMBER OF ROCKETS = 10  --------------------------------------------------------------------------------------------------------
    void spawnrockets2()
    {
        //entering _time2=37
        // set 1----------------------------------------------------------------------------------------------------------------------------------------------------------------
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
            if (_time2==48)
            {
                CancelInvoke("spawnrockets2");
                InvokeRepeating("spawnrock3",1f,2f);
            }
            _time2++;
           
        }
        //EXIT time=48
      
    }
    //=======================================================================SPAWNING SET 3=============================================================================================================================
    //--------------------------------------------------------------------ROCKET SPAWN TIME = 2sec---------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------NUMBER OF ROCKETS=  19-------------------------------------------------------------------------------------------------------------------------
    void spawnrock3()
    {
        //ENTER time = 49
        plat.SetActive(true);
        platform.instance.move = true;
         //set 1---------------------------------------------------------------------------------------------------------------------------------------------------
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
       //set 2-------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=60)
        {
            platform.instance.move = false;
        }
        if(_time2>=63)
        {
            plat.SetActive(false);
        }
        if (_time2 >= 64 && (_time2 == 65 || _time2 == 69 || _time2 == 71) && _time2 < 72 && stopspawning == false)
        {
            Instantiate(failyrocket, new Vector3(transform.position.x, Random.Range(y1, 0.24f)), Quaternion.identity);
        }
        //set 3---------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==73 && stopspawning == false)
        {
            plat2.SetActive(true);
            platform2.instance.move = true;
        }
        if(_time2>=74&&_time2<77 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(-3.16f, y1)), Quaternion.identity);
        }
        if(_time2>=77 && stopspawning == false)
        {
            platform2.instance.move = false;
        }
        //set 4---------------------------------------------------------------------------------------------------------------------
        if(_time2>=79&&_time2<83 && stopspawning == false)
        {
            plat2.SetActive(false);
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y2)), Quaternion.identity);
        }
        if (_time2==83 && stopspawning == false)
        {
            danger.instance.activated = true;
        }
        //set 5--------------------------------------------------------------------------------------------------------------------------
        if(_time2==86 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -4f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1.91f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.12f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.99f), Quaternion.identity);
        }
        if(_time2==87 && stopspawning == false)
        {
            CancelInvoke("spawnrock3");
            InvokeRepeating("spawnrock4", 2f, 1.25f);
        }
        _time2++;
       
        //exit time =88

    }
   //================================================================================SPAWNING SET 4========================================================================
   //---------------------------------------------------------------------------ROCKET SPAWN TIME=1.25 SEC -------------------------------------------------------------------------
   //--------------------------------------------------------------------------NUMBER OF ROCKETS = 65-------------------------------------------------------------------------------
   
    void spawnrock4()
    {
        //enter _time2 = 89
       //SET 1--------------------------------------------------------------------------------------------------------------------------------------------------------------------
       if(_time2==89)
        {
            Vector3 v = new Vector3(0, 0, 0);      //6 rockets
            Instantiate(roundaboutrocket, v, Quaternion.identity);
        }
       if(_time2>=91&&_time2<=94)
        {
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
            Instantiate(rocket,v,Quaternion.identity);
        }
        //SET 2---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==95&&stopspawning==false)
        {
            pole1.instance.moved = true;
        }
        if(_time2>=96&&_time2<102)
        {
            Vector3 v = new Vector3(transform.position.x, Random.Range(1.7f, -4.2f), 0);       //6 rockets
            Instantiate(rocket, v, Quaternion.identity);
        }
        if(_time2==102&&stopspawning==false)
        {
            pole1.instance.moved = false;
        }
        //SET 3--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==104&&stopspawning==false)
        {
            Pusher1.SetActive(true);
            pusher.instance.forcemove = true;
        }
        if(_time2==108)
        {
            Pusher1.SetActive(false);
        }
        //SET4---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=109&&stopspawning==false&&_time2<112)
        {
            if (_time2 == 109 || _time2 == 111)
            {
                Vector3 v = new Vector3(transform.position.x, -4.2f, 0);
                Instantiate(rocket, v, Quaternion.identity);
            }                                                                                            //3 rockets
        }
       if(_time2==112&&stopspawning==false)
        {
            Vector3 v = new Vector3(transform.position.x, -0.3f, 0);
            Instantiate(failyrocket, v, Quaternion.identity);
        }
        //SET 5-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>112&&_time2<126&&stopspawning == false)
        {
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
            Instantiate(rocket, v, Quaternion.identity);                                                //13 rockets
        }
        //SET 6 --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==127&& stopspawning == false)
        {
            plat.SetActive(true);
            platform.instance.move=true;
        }
        if(_time2>=130&&_time2<137)
        { 
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, 0.7f), 0);
            Instantiate(rocket, v, Quaternion.identity);
        }
        if(_time2>=137&&_time2<144)                                                                    //14 rockets
        {
            Vector3 V = new Vector3(transform.position.x, Random.Range(-0.7f, y3), 0);
            Instantiate(rocket, V, Quaternion.identity);
        }
        if(_time2==144)
        {
            platform.instance.move = false;
        }
        if(_time2==147)
        {
            plat.SetActive(false);
        }
        //SET 7-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=148&&_time2<150 && stopspawning == false)
        {
            Vector3 V = new Vector3(transform.position.x, Random.Range(y1, y3), 0);
            Instantiate(rocket, V, Quaternion.identity);
        }
        if(_time2==150 && stopspawning == false)
        {
            Vector3 V = new Vector3(transform.position.x, Random.Range(y1, y2), 0);
            Instantiate(failyrocket, V, Quaternion.identity);
        }
        if(_time2>=151&&_time2<153 && stopspawning == false)
        {
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);                //6 rockets
            Instantiate(rocket, v, Quaternion.identity);
        }
        if (_time2 == 153 && stopspawning == false)
        {
            Vector3 V = new Vector3(transform.position.x, Random.Range(y1, y2), 0);
            Instantiate(failyrocket, V, Quaternion.identity);
        }
        //SET 8-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (_time2 >= 157 && _time2 < 166 && stopspawning == false)
        {
            if (_time2 % 2 != 0)
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y2), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }                                                                                      //9 rockets
            else
            {
                Vector3 v = new Vector3(transform.position.x, Random.Range(y2, y3), 0);
                Instantiate(rocket, v, Quaternion.identity);
            }
        }
        //SET 9---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==166 && stopspawning == false)
        {
           
            danger.instance.activated = true;
        }
        if(_time2==169 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -4f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1.91f), Quaternion.identity);             //8 rockets
            Instantiate(rocket, new Vector3(transform.position.x, 3.12f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.99f), Quaternion.identity);
        }
        if(_time2==170 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -4f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.99f), Quaternion.identity);
        }
        if(_time2==172 && stopspawning == false)
        {
            CancelInvoke("spawnrock4");
            InvokeRepeating("spawnrock5", 1, 1.6f);
        }
        //exit time == 172

        _time2++;
    }
    //================================================================================= SPAWNING SET 5 =============================================================================
    //----------------------------------------------------------------------------ROCKET SPAWN TIME = 1.6 sec------------------------------------------------------------------------
    //----------------------------------------------------------------------------NUMBER OF ROCKETS =   21      -------------------------------------------------------------------------
     void spawnrock5()
    {
        //SET 1------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==173 && stopspawning == false)
        {
            Pusher1.SetActive(true);
            pusher.instance.forcemove = true;
        }
        if(_time2==177 && stopspawning == false)
        {
            Pusher1.SetActive(false);
            charger.instance.moved = true;
        }
        if(_time2>=177&&_time2<183 && stopspawning == false)
        {
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, -3.1f), 0);         //5
            Instantiate(rocket, v, Quaternion.identity);
        }
        if(_time2==183 && stopspawning == false)
        {
           
            Pusher2.SetActive(true);
            pusher1.instance.forcemove = true;
        }
        if(_time2==187)
        {
            Pusher2.SetActive(false);
            charger.instance.moved = false;
        }
        //SET 2----------------------------------------------------------------------------------------------------------------------------------------------------------------

        if (_time2== 188 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3), 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3), 0), Quaternion.identity);
        }
        if(_time2== 190 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3), 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3), 0), Quaternion.identity);    //6
        }
        if(_time2== 192 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3), 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3), 0), Quaternion.identity);
        }
        //SET 3-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=193 &&_time2<196 && stopspawning == false)
        {
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, 0f), 0);                              //4
            Instantiate(failyrocket, v, Quaternion.identity);                                              
        }
        //SET 4-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
       if(_time2== 197 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -4.17f, 0), Quaternion.identity);
        }
       if(_time2== 198 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -2.8f, 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -4.1f, 0), Quaternion.identity);            //6
        }
        if (_time2 == 200 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -1f, 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2.8f, 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -4.1f, 0), Quaternion.identity);
        }
        if(_time2 == 201 && stopspawning == false)
        {
            CancelInvoke("spawnrock5");
            InvokeRepeating("spawnrock6",1,1.22f);
        }
        _time2++;
        //exit time =200
    }
    //====================================================================================== SPAWNING SET 6 ==============================================================================
    //--------------------------------------------------------------------------------- ROCKET SPAWN TIME =1.22 sec -------------------------------------------------------------------------
    //--------------------------------------------------------------------------------NUMBER OF ROCKETS =    38       -------------------------------------------------------------------------
    void spawnrock6()
    {
        //SET 1-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=202&&_time2< 220 && stopspawning == false)
        {
            if(_time2==205||_time2==218)
            {
                Instantiate(roundaboutrocket, new Vector3(0, Random.Range(y1, y2), 0) , Quaternion.identity);
            }
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, y3), 0);                              //20
            Instantiate(rocket, v, Quaternion.identity);
        }
        //SET 2-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=222&&_time2< 230 && stopspawning == false)
        {
            if(_time2==225&&stopspawning==false)
            {
                pole1.instance.moved = true;
            }
            Vector3 v = new Vector3(transform.position.x, y3, 0);
            Instantiate(rocket, v, Quaternion.identity);                                                         //8
        }
        //SET3 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (_time2== 231 && stopspawning == false)
        {
            pole1.instance.moved = false;
            plat2.SetActive(true);
            platform2.instance.move = true;
        }
        if(_time2>=232&&_time2< 236 && stopspawning == false)
        {
            Vector3 v = new Vector3(transform.position.x, Random.Range(y1, -3.16f), 0);                              //4
            Instantiate(rocket, v, Quaternion.identity);
        }
        if(_time2==236)
        {
            platform2.instance.move = false;
        }
        if(_time2==238)
        {
           
            plat2.SetActive(false);
        }
        //SET 4 ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2== 239 && stopspawning == false)
        {
            danger.instance.activated = true;
        }
        if(_time2== 243 && stopspawning == false)
        {
            
            Instantiate(rocket, new Vector3(transform.position.x, 3.7f, 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -4.21f, 0), Quaternion.identity);
        }
        if (_time2 == 244 && stopspawning == false)
        {
            Instantiate(rocket, new Vector3(transform.position.x, 2.29f, 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2.8f, 0), Quaternion.identity);                          //6
        }
        if (_time2 == 245 && stopspawning == false)
        {
          
            Instantiate(rocket, new Vector3(transform.position.x, 1.9f, 0), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2f, 0), Quaternion.identity);
        }
        if(_time2==246)
        {
            CancelInvoke("spawnrock6");
            InvokeRepeating("spawnrock7", 1, 1.6f);
        }
        _time2++;
    }
   // =============================================================================================SPAWNING SET 7================================================================
   //---------------------------------------------------------------------------------------MECHANISM WORK GAP = 1.6 sec --------------------------------------------------------
   //------------------------------------------------------------------------------------NUMBER OF ROCKETS = 8-------------------------------------------------------------------
 
    void spawnrock7()
    {
        //SET1---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==248)
        {
            Pusher1.SetActive(true);
            pusher1.instance.forcemove = true;
        }
        if (_time2 == 249)
        {
            Pusher3.SetActive(true);
            pusher2.instance.forcemove = true;
        }
        if(_time2==252)
        {
            Pusher1.SetActive(false);
        }
        if(_time2==253)
        {
            Pusher3.SetActive(false);
        }
        //SET 2-----------------------------------------------------------------------------------------------------------------------------------------------------------------
       if(_time2>=254&&_time2<260)
        {
            if (_time2 == 255||_time2==258)
            {
                Instantiate(roundaboutrocket, new Vector3(transform.position.x, Random.Range(y1, y2), 0), Quaternion.identity);
            }
            else
            {
                Instantiate(rocket, new Vector3(transform.position.x, Random.Range(y1, y3), 0), Quaternion.identity);         //8
            }                                                                                                           
        }
       //SET 3------------------------------------------------------------------------------------------------------------------------------------------------------------------
       if(_time2==261)
        {
            Pusher1.SetActive(true);
            pusher.instance.forcemove = true;
        }
       if(_time2==262)
        {
            Pusher3.SetActive(true);
            pusher2.instance.forcemove = true;
        }
       if(_time2==263)
        {
            Pusher2.SetActive(true);
            pusher1.instance.forcemove = true;
        }
       if(_time2==264)
        {
            pusher2.instance.forcemove = true;
        }
        if(_time2==265)
        {
            pusher.instance.forcemove = true;
            Pusher2.SetActive(false);
        }
        //SET 4----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==267)
        {
            plat.SetActive(true);
            platform.instance.move = true;
        }
        if(_time2==269)
        {
            pusher.instance.forcemove = true;
            pusher2.instance.forcemove = true;
        }
        if(_time2==272)
        {
            platform.instance.move = false;
        }
        if(_time2==274)
        {
            plat.SetActive(false);
            Pusher1.SetActive(false);
            Pusher3.SetActive(false);
            CancelInvoke("spawnrock7");
            InvokeRepeating("spawnrock8", 1, 1.2f);
        }
        _time2++;
    }
    //===============================================================SPAWNING SET 8====================================================================================
    //----------------------------------------------------------ROCKET SPAWN TIME =1.2 sec---------------------------------------------------------------------------
    //-------------------------------------------------------NUMBER OF ROCKETS =  45------------------------------------------------------------------------------
    void spawnrock8()
    {
       
        if (_time2 == 275)
        {
          
            pole1.instance.moved = true;
            charger.instance.moved = true;
        }
        //SET1 -------------------------------------------------------------------------------------------------------------------------------------------------------
        if (_time2 >= 276&&_time2<288)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(1.95f, -3.1f),0), Quaternion.identity); //12
        }
        if(_time2==289)
        {
            Pusher2.SetActive(true);
            pusher1.instance.forcemove = true;
        }
        if(_time2==293)
        {
            Pusher2.SetActive(false);
        }
        //SET2-------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=294&&_time2<296)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -3.05f, 0), Quaternion.identity);
        }
        if(_time2>=298&&_time2<301)                                                                                      //6
        {
            Instantiate(rocket, new Vector3(transform.position.x, -2.6f, 0), Quaternion.identity);
        }
        //SET 3---------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2>=302&&_time2<311)
        {
            Instantiate(rocket, new Vector3(transform.position.x, Random.Range(1.95f, -3.1f), 0), Quaternion.identity); //10
        }
        //SET 4---------------------------------------------------------------------------------------------------------------------------------------------------------------
        if(_time2==312&&_time2==313)
        {
            Instantiate(failyrocket, new Vector3(transform.position.x, Random.Range(3.58f, 3.56f), 0), Quaternion.identity);//2
        }
        if(_time2==314)
        {
            charger.instance.moved = false;
            pole1.instance.moved = false;
            danger.instance.activated = true;
        }
        //SET 5
        if(_time2==317||_time2==318||_time2==319)
        {
            Instantiate(rocket, new Vector3(transform.position.x, -4f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, -2f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 1.91f), Quaternion.identity);     //15
            Instantiate(rocket, new Vector3(transform.position.x, 3.12f), Quaternion.identity);
            Instantiate(rocket, new Vector3(transform.position.x, 3.99f), Quaternion.identity);
        }
        if(_time2==318)
        {
            _time2 = 0;
            CancelInvoke("spawnrock8");
            StartCoroutine(spawn(0));
        }
         _time2++;
    }
 
}
