using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveActiveCardTo : MonoBehaviour
{
    [SerializeField] float speed = 20f;
	
	
	
    GameObject DestObj;
	public AudioSource wrongAudio;

	persist_state state;
	CardMaker cardMaker;

    public void setAsDest(GameObject Obj) {
		if (state.activeCard.GetComponent<category>().cat == Obj)
		{
        DestObj = Obj;
        Debug.Log("start moving");
		}else{
			wrongAudio.Play();
		}
	}

    void Start()
    {
		state = GameObject.Find("persist_State").GetComponent<persist_state>();
		cardMaker = GameObject.Find("sort").GetComponent<CardMaker>();


    }

    // Update is called once per frame
    void Update () {
        if (DestObj){
            float step = speed * Time.deltaTime;
			Transform source = state.activeCard.transform;
            source.position = Vector2.MoveTowards(source.position, DestObj.transform.position, step);  
            source.localScale = Vector2.MoveTowards(source.localScale,new Vector2(0.13f,0.13f),step/5);  
            if(Vector2.Distance( source.position,DestObj.transform.position) <= 0 ){
                DestObj = null;
                Debug.Log("stop moving");
				cardMaker.nextActiveCard();
				
                //gameObject.transform.position = new  Vector2(0,0);
                //gameObject.transform.localScale = new  Vector2(0.32f,0.32f);
            }
        }
    }
	

	
}
