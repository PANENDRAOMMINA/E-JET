using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour
{
    // Start is called before the first frame update
    private int unitdigit = 0;
    public static scoreboard instance;
    public GameObject[] number = new GameObject[10];
    public GameObject[] ten = new GameObject[10];
    public GameObject[] hundred = new GameObject[10];
    private int tendigit = 0;
    private int hundreddigit = 0;
    private Animator anim;
    public GameObject gameobject1;
    public Text highscore;
    
    
    private int score;
    
     void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        anim = GetComponent<Animator>();
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
      
        
       
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increaseunit()
    {
        unitdigit++;
        if(unitdigit<=9)
        {
            number[unitdigit].SetActive(true);
            number[unitdigit - 1].SetActive(false);
            
        }    
        else
        {
            increaseten();
            number[0].SetActive(true);
            number[9].SetActive(false);
            unitdigit = 0;
        }
    }
    void increaseten()
    {
        tendigit++;
        if(tendigit<=9)
        {
            ten[tendigit].SetActive(true);
            ten[tendigit - 1].SetActive(false);
        }
        else
        {
            ten[0].SetActive(true);
            ten[9].SetActive(false);
            increasehundred();
            tendigit = 0;
            
        }
    }
    void increasehundred()
    {
        hundreddigit++;
        if(hundreddigit<=9)
        {
            hundred[hundreddigit].SetActive(true);
            hundred[hundreddigit - 1].SetActive(false);
           
        }
    }
    public void countscore()
    {
       
        score = hundreddigit * 100 + tendigit * 10 + unitdigit;
        if(score>PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }

    }
    public void restart()
    {
        SceneManager.LoadScene(1);
        
    }
    public void  menu()
    {
        SceneManager.LoadScene(0);
        admanager.instance.showinterstitialad();
        
    }

    public void displayscore()
    {
        StartCoroutine(display(2f));
    }
    IEnumerator display(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        anim.enabled = true;
        yield return new WaitForSecondsRealtime(0.5f);
        gameobject1.SetActive(true);
    }


   
}
