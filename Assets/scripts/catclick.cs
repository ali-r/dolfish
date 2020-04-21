using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catclick : MonoBehaviour
{
    public moveActiveCardTo control; 
    void Start()
    {
        control = GameObject.Find("stayOutCard").GetComponent<moveActiveCardTo>();   
    }
    void OnMouseDown()
    {
        control.setAsDest(gameObject);
    }

}
