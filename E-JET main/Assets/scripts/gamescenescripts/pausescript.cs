using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pause;
    public bool ispaused = false;
    public static pausescript instance;
   
    public void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
        admanager.instance.requestinterstitial();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            admanager.instance.showinterstitialad();
            Time.timeScale = 0f;
            pause.SetActive(true);
           
        }
    }
    public void resume()
    {
        
        pause.SetActive(false);
        Time.timeScale = 1f;
        
        
    }
    public void menu()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        
    }
}
