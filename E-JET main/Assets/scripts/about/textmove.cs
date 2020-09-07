using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textmove : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
       
     }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector2.up * 0.6f * Time.deltaTime);
    }
}
