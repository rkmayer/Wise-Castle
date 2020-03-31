using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalShopScript : MonoBehaviour
{
   //retrieve all buttons (shop items)
	public Button bunny1, bunny2, bunny3, bunny4, bunny5, bunny6,
				cat1, cat2, cat3, cat4, cat5, cat6,
				turtle1, turtle2, turtle3, turtle4, turtle5, turtle6;
	
	//prices
	public int bunnyPrice, catPrice, turtlePrice;
	
	//sold out image
	public Sprite sold_out;
	
    // Start is called before the first frame update
    void Start()
    {
		//make sure all items are updated
		updateItems();
		
        //listeners for all buttons
		bunny1.onClick.AddListener(() => buyItem("bunny1", bunnyPrice, bunny1));
		bunny2.onClick.AddListener(() => buyItem("bunny2", bunnyPrice, bunny2));
		bunny3.onClick.AddListener(() => buyItem("bunny3", bunnyPrice, bunny3));
		bunny4.onClick.AddListener(() => buyItem("bunny4", bunnyPrice, bunny4));
		bunny5.onClick.AddListener(() => buyItem("bunny5", bunnyPrice, bunny5));
		bunny6.onClick.AddListener(() => buyItem("bunny6", bunnyPrice, bunny6));
		
		cat1.onClick.AddListener(() => buyItem("cat1", catPrice, cat1));
		cat2.onClick.AddListener(() => buyItem("cat2", catPrice, cat2));
		cat3.onClick.AddListener(() => buyItem("cat3", catPrice, cat3));
		cat4.onClick.AddListener(() => buyItem("cat4", catPrice, cat4));
		cat5.onClick.AddListener(() => buyItem("cat5", catPrice, cat5));
		cat6.onClick.AddListener(() => buyItem("cat6", catPrice, cat6));
		
		turtle1.onClick.AddListener(() => buyItem("turtle1", turtlePrice, turtle1));
		turtle2.onClick.AddListener(() => buyItem("turtle2", turtlePrice, turtle2));
		turtle3.onClick.AddListener(() => buyItem("turtle3", turtlePrice, turtle3));
		turtle4.onClick.AddListener(() => buyItem("turtle4", turtlePrice, turtle4));
		turtle5.onClick.AddListener(() => buyItem("turtle5", turtlePrice, turtle5));
		turtle6.onClick.AddListener(() => buyItem("turtle6", turtlePrice, turtle6));
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
		Button[] buttons = {bunny1, bunny2, bunny3, bunny4, bunny5, bunny6,
				cat1, cat2, cat3, cat4, cat5, cat6,
				turtle1, turtle2, turtle3, turtle4, turtle5, turtle6};
	
		//set names for buttons
		bunny1.name = "bunny1"; bunny2.name = "bunny2"; bunny3.name = "bunny3";
		bunny4.name = "bunny4"; bunny5.name = "bunny5"; bunny6.name = "bunny6";
		cat1.name = "cat1"; cat2.name = "cat2"; cat3.name = "cat3";
		cat4.name = "cat4"; cat5.name = "cat5"; cat6.name = "cat6";
		turtle1.name = "turtle1"; turtle2.name = "turtle2"; turtle3.name = "turtle3";
		turtle4.name = "turtle4"; turtle5.name = "turtle5"; turtle6.name = "turtle6";
		
		//go through buttons checking for purchase flags
		foreach(Button button in buttons){
			//set default bunny to always purchased
			if(button.name == "bunny1"){
				PlayerPrefs.SetInt("bunny1", 1);
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
