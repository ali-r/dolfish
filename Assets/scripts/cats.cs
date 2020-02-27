using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;


public class cats : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        float r = 2f;
        for (int i = 0; i <= 5; i++) 
        {
            GameObject cat = this.transform.GetChild(i).gameObject; 
            Vector3 pos = cat.transform.position;
            pos.x = r * (float)Math.Sin(i* 2*Math.PI / 6);
            pos.y = r * (float)Math.Cos(i* 2*Math.PI / 6);
            cat.transform.position = pos;
            Debug.Log(pos);
        }
        Debug.Log("hello");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
