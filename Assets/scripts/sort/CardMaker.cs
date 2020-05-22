using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using System.IO;
using System.Linq; //OrderBy 



public class CardMaker : MonoBehaviour
{
	
	//public Sprite[] cardImgs ; 
	public ScriptableObject[] cats ; 

	
	GameObject cardPrefab;
	
	persist_state state;
	
	(Cat_so,Sprite)[] all_cards_shuffled;// 

    void Start()
    {
		state = GameObject.Find("persist_State").GetComponent<persist_state>();
		
        cardPrefab = Resources.Load("card_prefab", typeof(GameObject)) as GameObject;
		var sr = cardPrefab.GetComponent<SpriteRenderer>();
		sr.sortingOrder = 25;
			
		var r = new System.Random();
		all_cards_shuffled = cards().ToArray().OrderBy(x => r.Next()).ToArray();
		make(0);
		make(1);
		state.activeCard = state.cards[0];

    }
	
	void make(int n)
	{
		Debug.Log("oof");
		var (cat, img) = all_cards_shuffled[n];
		cardPrefab.GetComponent<category>().cat = cat;
		
		SpriteRenderer sr = cardPrefab.GetComponent<SpriteRenderer>();
		sr.sprite = img ;
		sr.sortingOrder -= 1;
		var card = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		card.name = "card"+n;
		state.cards.Add(card);
	}
	
	public void nextActiveCard(){
		if (state.cards.Count < all_cards_shuffled.Length){
			make(state.cards.Count);
			state.activeCard = state.cards[state.cards.Count-2];
		}else{
			state.activeCard = state.cards[state.cards.Count-1];
		}
	}
	
	
	IEnumerable<(Cat_so,Sprite)> cards(){
		foreach(Cat_so cat in cats)
		{
			foreach(Sprite cardImg in cat.cardImgs){
				Debug.Log("ooz");
				yield return(cat,cardImg);
			}
		}
	}
	

}
