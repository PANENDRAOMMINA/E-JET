using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pause;
    public bool ispaused;
    public static pausescript instance;
    public Animator anim;

   
    public void Awake()
    {
        ispaused = true;
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&ispaused)
        {

            //admanager.instance.showinterstitialad();
            Time.timeScale = 0f;
            pause.SetActive(true);
            anim.SetBool("ispaused", true);
           
        }
    }
    public void resume()
    {
        
        pause.SetActive(false);
        Time.timeScale = 1f;
        audiomanager.instance.play("click");
    }
    public void menu()
    {
        audiomanager.instance.play("click");
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
