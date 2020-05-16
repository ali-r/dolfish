using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector2 scale = this.transform.localScale ;
		scale.x += 4f*Time.deltaTime;
        this.transform.localScale = scale;
    }
}
