using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persist_state : MonoBehaviour
{
	
	[SerializeField] public List<GameObject> cards = new List<GameObject>();
	
	public GameObject activeCard = null;
	
	
	public float remainedSortTime = 25f; 
	
	
	
	public Dictionary<Cat_so, List<GameObject>> inCatCards = new Dictionary<Cat_so, List<GameObject>>()  ;
	
    // Start is called before the first frame update
    void Start()
    {
		
    }
	
	/* public List<GameObject> getCards()
	{
		return cards;
	}
	
	public GameObject getActiveCard(){
	
	activeCard = 
	} */
	
	
	
}
