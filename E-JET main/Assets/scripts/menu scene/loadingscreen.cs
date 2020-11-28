using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class loadingscreen : MonoBehaviour
{
  public Animator anim;
    [TextArea(5,6)]public string[] sentences;
    public Text text;
    public void loadscreen()
    {
        anim.SetBool("loadingscreen", true);
        sentencemechanism();
        anim.SetBool("loading bar",true);
        StartCoroutine(loadscene(7f));
    }

    private void sentencemechanism()
    {
        anim.SetBool("sentence formation", true);
        StartCoroutine(changesentence(5f));
    }
    IEnumerator loadscene(float time)
    {
        yield return new WaitForSeconds(time);
        anim.SetBool("loadscene", true);
        FindObjectOfType<menuUI>().loadgameplay();
    }
    IEnumerator changesentence(float time)
    {
        int t = Random.Range(0, 4);
        text.text = sentences[t].ToString();
        yield return new WaitForSecondsRealtime(time);
        StartCoroutine(changesentence(5f));
    }
}
