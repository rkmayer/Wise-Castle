/*
RobeShopScript - allows player to buy robes from the store

Ryan Mayer
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobeShopScript : MonoBehaviour
{
	//retrieve all buttons (shop items)
	public Button robe1grey, robe1red, robe1blue, robe1green, robe1orange, robe1purple,
		robe2grey, robe2red, robe2blue, robe2green, robe2orange, robe2purple,
		robe3grey, robe3red, robe3blue, robe3green, robe3orange, robe3purple;
	
	public int robe1price, robe2price, robe3price;
	
    // Start is called before the first frame update
    void Start()
    {
		//array of buttons
		Button[] buttons = {robe1grey, robe1red, robe1blue, robe1green, robe1orange, robe1purple,
		robe2grey, robe2red, robe2blue, robe2green, robe2orange, robe2purple,
		robe3grey, robe3red, robe3blue, robe3green, robe3orange, robe3purple};
	
		//set names for buttons
		robe1grey.name = "robe1grey"; robe1red.name = "robe1red";
		robe1blue.name = "robe1blue"; robe1green.name = "robe1green";
		robe1orange.name = "robe1orange"; robe1purple.name = "robe1purple";
		robe2grey.name = "robe2grey"; robe2red.name = "robe2red";
		robe2blue.name = "robe2blue"; robe2green.name = "robe2green";
		robe2orange.name = "robe2orange"; robe2purple.name = "robe2purple";
		robe3grey.name = "robe3grey"; robe3red.name = "robe3red";
		robe3blue.name = "robe3blue"; robe3green.name = "robe3green";
		robe3orange.name = "robe3orange"; robe3purple.name = "robe3purple";
		
		//go through buttons checking for purchase flags
		foreach(Button button in buttons){
			if(PlayerPrefs.GetInt(button.name, 0) == 1){
				//the item is purchased, set interactable to false
				button.interactable = false;
			}
		}
		
        //listeners for all buttons
		robe1grey.onClick.AddListener(() => buyItem("robe1grey", robe1price, robe1grey));
		robe1red.onClick.AddListener(() => buyItem("robe1red", robe1price, robe1red));
		robe1blue.onClick.AddListener(() => buyItem("robe1blue", robe1price, robe1blue));
		robe1green.onClick.AddListener(() => buyItem("robe1green", robe1price, robe1green));
		robe1orange.onClick.AddListener(() => buyItem("robe1orange", robe1price, robe1orange));
		robe1purple.onClick.AddListener(() => buyItem("robe1purple", robe1price, robe1purple));
		
		robe2grey.onClick.AddListener(() => buyItem("robe2grey", robe2price, robe2grey));
		robe2red.onClick.AddListener(() => buyItem("robe2red", robe2price, robe2red));
		robe2blue.onClick.AddListener(() => buyItem("robe2blue", robe2price, robe2blue));
		robe2green.onClick.AddListener(() => buyItem("robe2green", robe2price, robe2green));
		robe2orange.onClick.AddListener(() => buyItem("robe2orange", robe2price, robe2orange));
		robe2purple.onClick.AddListener(() => buyItem("robe2purple", robe2price, robe2purple));
		
		robe3grey.onClick.AddListener(() => buyItem("robe3grey", robe3price, robe3grey));
		robe3red.onClick.AddListener(() => buyItem("robe3red", robe3price, robe3red));
		robe3blue.onClick.AddListener(() => buyItem("robe3blue", robe3price, robe3blue));
		robe3green.onClick.AddListener(() => buyItem("robe3green", robe3price, robe3green));
		robe3orange.onClick.AddListener(() => buyItem("robe3orange", robe3price, robe3orange));
		robe3purple.onClick.AddListener(() => buyItem("robe3purple", robe3price, robe3purple));
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
	}
}
