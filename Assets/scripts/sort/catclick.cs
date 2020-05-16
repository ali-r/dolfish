using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catclick : MonoBehaviour
{
    public moveActiveCardTo moveScript; 
		
		
    void Start()
    {
        moveScript = GameObject.Find("sort").GetComponent<moveActiveCardTo>();   
    }
    void OnMouseDown()
    {
        moveScript.setAsDest(gameObject);
    }

}
