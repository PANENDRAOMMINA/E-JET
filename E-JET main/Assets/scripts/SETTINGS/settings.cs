using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class settings : MonoBehaviour
{
    public audiomanager audio;
    public GameObject audiomanager;
    public int enableaudio;
   

    private void Awake()
    {
        audio = audiomanager.GetComponent<audiomanager>();
        audio.play("mainmenu");
    }

    public void toggleaudio()
    {
        enableaudio = PlayerPrefs.GetInt("enableaudio");
        if(enableaudio==1)
        {
            audiomanager.SetActive(false);
            
            PlayerPrefs.SetInt("enableaudio", 0);
            Debug.Log(1);
        }
        else
        {
            audiomanager.SetActive(true);
            PlayerPrefs.SetInt("enableaudio", 1);
            Debug.Log(0);
        }
     
       
    }

}
