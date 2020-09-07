using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingscene3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadscene2(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator loadscene2(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene(2);
    }
}
