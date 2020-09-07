using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowlight : MonoBehaviour
{
    public float time = 1;
    private int activating_time, closing_time, running_time;
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Light(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Light(float time)
    {
        activating_time = Random.Range(0, 4);
        closing_time = Random.Range(4, 7);
        if (running_time > activating_time && running_time < closing_time)
        {
            arrow.SetActive(true);
        }
        else if(running_time>closing_time&&running_time<9)
        {
            arrow.SetActive(false);
        }
        else if(running_time>9)
        {
            running_time = 0;
        }
        running_time++;
        yield return new WaitForSecondsRealtime(time);
        StartCoroutine(Light(time));
    }
}
