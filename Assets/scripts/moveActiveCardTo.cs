using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveActiveCardTo : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    GameObject DestObj;
    //GameObject ActiveCard;
    public void setAsDest(GameObject Obj) {
        DestObj = Obj;
        Debug.Log("start moving");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        if (DestObj){
            float step = speed * Time.deltaTime;
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, DestObj.transform.position, step);  
            gameObject.transform.localScale = Vector2.MoveTowards(gameObject.transform.localScale,new Vector2(0.13f,0.13f),step/5);  
            if(Vector2.Distance( gameObject.transform.position,DestObj.transform.position) <= 0 ){
                DestObj = null;
                Debug.Log("stop moving");
                //gameObject.transform.position = new  Vector2(0,0);
                //gameObject.transform.localScale = new  Vector2(0.32f,0.32f);
            }
        }
    }
}
