/*
HatShopScript - allows user to buy hats from the store
item id structure: [item][version][colour]

Ryan Mayer
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatShopScript : MonoBehaviour
{
	//retrieve all buttons (shop items)
	public Button hat1black, hat1white, hat1red, hat1yellow, hat1green, hat1blue, hat1pink, hat1purple,
		hat2black, hat2white, hat2red, hat2yellow, hat2green, hat2blue, hat2pink, hat2purple,
		hat3black, hat3white, hat3red, hat3yellow, hat3green, hat3blue, hat3pink, hat3purple;
	
	//prices
	public int hat1price, hat2price, hat3price;
	
	//sold out image
	public Sprite sold_out;
	
    // Start is called before the first frame update
    void Start()
    {
		//make sure all items are updated
		updateItems();
		
        //listeners for all buttons
		hat1black.onClick.AddListener(() => buyItem("hat1black", hat1price, hat1black));
		hat1white.onClick.AddListener(() => buyItem("hat1white", hat1price, hat1white));
		hat1red.onClick.AddListener(() => buyItem("hat1red", hat1price, hat1red));
		hat1yellow.onClick.AddListener(() => buyItem("hat1yellow", hat1price, hat1yellow));
		hat1green.onClick.AddListener(() => buyItem("hat1green", hat1price, hat1green));
		hat1blue.onClick.AddListener(() => buyItem("hat1blue", hat1price, hat1blue));
		hat1pink.onClick.AddListener(() => buyItem("hat1pink", hat1price, hat1pink));
		hat1purple.onClick.AddListener(() => buyItem("hat1purple", hat1price, hat1purple));
		
		hat2black.onClick.AddListener(() => buyItem("hat2black", hat2price, hat2black));
		hat2white.onClick.AddListener(() => buyItem("hat2white", hat2price, hat2white));
		hat2red.onClick.AddListener(() => buyItem("hat2red", hat2price, hat2red));
		hat2yellow.onClick.AddListener(() => buyItem("hat2yellow", hat2price, hat2yellow));
		hat2green.onClick.AddListener(() => buyItem("hat2green", hat2price, hat2green));
		hat2blue.onClick.AddListener(() => buyItem("hat2blue", hat2price, hat2blue));
		hat2pink.onClick.AddListener(() => buyItem("hat2pink", hat2price, hat2pink));
		hat2purple.onClick.AddListener(() => buyItem("hat2purple", hat2price, hat2purple));
		
		hat3black.onClick.AddListener(() => buyItem("hat3black", hat3price, hat3black));
		hat3white.onClick.AddListener(() => buyItem("hat3white", hat3price, hat3white));
		hat3red.onClick.AddListener(() => buyItem("hat3red", hat3price, hat3red));
		hat3yellow.onClick.AddListener(() => buyItem("hat3yellow", hat3price, hat3yellow));
		hat3green.onClick.AddListener(() => buyItem("hat3green", hat3price, hat3green));
		hat3blue.onClick.AddListener(() => buyItem("hat3blue", hat3price, hat3blue));
		hat3pink.onClick.AddListener(() => buyItem("hat3pink", hat3price, hat3pink));
		hat3purple.onClick.AddListener(() => buyItem("hat3purple", hat3price, hat3purple));
    }
	
	//buy item function
	void buyItem(string id, int cost, Button thisButton){
		int currentPoints = PlayerPrefs.GetInt("PlayerPoints", 0);
		if(currentPoints < cost){
			//cost is too high
			Debug.Log("cost too high");
			return;
		}
		if(PlayerPrefs.GetInt(id, 0) == 1){
			//already bought this item
			Debug.Log("already purchased");
			return;
		}
		
		//if cost is good and player has not bought the item...
		//subtract points
		int updatedPoints = currentPoints - cost;
		PlayerPrefs.SetInt("PlayerPoints", updatedPoints);
		//set item flag to purchased (1)
		PlayerPrefs.SetInt(id, 1);
		//update items
		updateItems();
	}
	
	//update items function
	void updateItems(){
		//array of buttons
		Button[] buttons = {hat1black, hat1white, hat1red, hat1yellow, hat1green, hat1blue, hat1pink, hat1purple,
			hat2black, hat2white, hat2red, hat2yellow, hat2green, hat2blue, hat2pink, hat2purple,
			hat3black, hat3white, hat3red, hat3yellow, hat3green, hat3blue, hat3pink, hat3purple};
	
		//set names for buttons
		hat1black.name = "hat1black"; hat1white.name = "hat1white";
		hat1red.name = "hat1red"; hat1yellow.name = "hat1yellow";
		hat1green.name = "hat1green"; hat1blue.name = "hat1blue";
		hat1pink.name = "hat1pink"; hat1purple.name = "hat1purple";
		hat2black.name = "hat2black"; hat2white.name = "hat2white";
		hat2red.name = "hat2red"; hat2yellow.name = "hat2yellow";
		hat2green.name = "hat2green"; hat2blue.name = "hat2blue";
		hat2pink.name = "hat2pink"; hat2purple.name = "hat2purple";
		hat3black.name = "hat3black"; hat3white.name = "hat3white";
		hat3red.name = "hat3red"; hat3yellow.name = "hat3yellow";
		hat3green.name = "hat3green"; hat3blue.name = "hat3blue";
		hat3pink.name = "hat3pink"; hat3purple.name = "hat3purple";
		
		//go through buttons checking for purchase flags
		foreach(Button button in buttons){
			//set default hat to always purchased
			if(button.name == "hat1black"){
				PlayerPrefs.SetInt("hat1black", 1);
				button.interactable = false;
			}else if(PlayerPrefs.GetInt(button.name, 0) == 1){
				//the item is purchased, set interactable to false
				button.interactable = false;
				//set image to sold out
				button.GetComponent<Image>().sprite = sold_out;
			}
		}
	}
}
