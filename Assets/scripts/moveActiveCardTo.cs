using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveActiveCardTo : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    GameObject DestObj;
    GameObject ActiveCard;
    public void setAsDest(GameObject Obj) {
        DestObj = Obj;
        Debug.Log("hihi");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        if (DestObj){
            float step = speed * Time.deltaTime;
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, DestObj.transform.position, step);
        }
    }
}
