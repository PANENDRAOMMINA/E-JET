using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playgame()
    {
        SceneManager.LoadScene(4);
        audiomanager.instance.play("click");
    }
    public void exit()
    {
        Application.Quit();
        audiomanager.instance.play("click");
    }

    public void about()
    {
        SceneManager.LoadScene(3);
        audiomanager.instance.play("click");

    }
    public void menu()
    {
        SceneManager.LoadScene(5);
        audiomanager.instance.play("click");
    }
    public void tutorial()
    {
        SceneManager.LoadScene(6);
        audiomanager.instance.play("click");}
    }
  

