using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pause;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           
            Time.timeScale = 0f;
            pause.SetActive(true);
            spawner.instance.stopspawning = true;
            
        }
    }
    public void resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        spawner.instance.stopspawning = false;

    }
    public void menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
