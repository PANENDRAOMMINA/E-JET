using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void about()
    {
        SceneManager.LoadScene("about");
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void help()
    {
        SceneManager.LoadScene(3);
    }
}
