﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SetUpSingelton();
    }

    public void SetUpSingelton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            //DontDestroyOnLoad(gameObject);
            Destroy(gameObject);
        }
        else
        {
            //Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
