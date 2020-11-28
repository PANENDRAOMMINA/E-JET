using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingscene1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadscene(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator loadscene(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene("settings");
    }
}
