using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMaker : MonoBehaviour
{
	
	public Sprite[] cardImgs ; 
	
	GameObject cardPrefab;
	
	persist_state state;

    void Start()
    {
		state = GameObject.Find("persist_State").GetComponent<persist_state>();
		
        cardPrefab = Resources.Load("card_prefab", typeof(GameObject)) as GameObject;
		SpriteRenderer sr = cardPrefab.GetComponent<SpriteRenderer>();
		sr.sortingOrder = 10;
		make(0);
		make(1);
		state.activeCard = state.cards[0];
		
    }
	
	void make(int n)
	{
		cardPrefab.GetComponent<category>().cat = GameObject.Find("cats").transform.GetChild(0).gameObject;
		
		SpriteRenderer sr = cardPrefab.GetComponent<SpriteRenderer>();
		sr.sprite = cardImgs[n] ;
		sr.sortingOrder -= 1;
		state.cards.Add(Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity));
	}
	
	public void nextActiveCard(){
		if (state.cards.Count < cardImgs.Length){
			make(state.cards.Count);
			state.activeCard = state.cards[state.cards.Count-2];
		}else{
			state.activeCard = state.cards[state.cards.Count-1];
		}
	}
	

}
