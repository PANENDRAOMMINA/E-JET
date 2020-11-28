using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class menuUI : MonoBehaviour
{
    public Animator anim;
    public GameObject canvas;
    public Camera maincamera;
    public void playgame()
    {
        startplayprocedure();
    }
    //ACTIONS WORKING IN MAIN MENU WHEN WE CLICKED THE PLAY BUTTON   ====================================
    private void startplayprocedure()
    {
        audiomanager.instance.play("click");
        canvas.SetActive(false);
        StartCoroutine(startmove());
        StartCoroutine(setcamera(3f));
    }
    public void loadgameplay()
    {
        StartCoroutine(loadgameplay(3f));
    }
    IEnumerator loadgameplay(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene("gameplay");
    }
    IEnumerator setcamera(float time)
    {
        yield return new WaitForSeconds(time);
        FindObjectOfType<camera>().movecamera = true;
        FindObjectOfType<loadingscreen>().loadscreen();
    }

    IEnumerator startmove()
    {
        anim.SetBool("startmove", true);
        yield return new WaitForSecondsRealtime(2f);
    }
    // ==========================  ABOVE  ACTIONS ARE PERFORMED WHEN PLAY BUTTON IS CLICKED ============================
    public void replay()
    {
        SceneManager.LoadScene("gameplay");
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
        SceneManager.LoadScene(4);
        audiomanager.instance.play("click");
    }
    public void tutorial()
    {
        SceneManager.LoadScene(5);
        audiomanager.instance.play("click");
    }


}

  

