using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalInventoryScript : MonoBehaviour
{
	//empty slot sprite
	[SerializeField] public Sprite emptySlot;
	
	//retrieve all buttons (inventory items)
	public Button bunny1, bunny2, bunny3, bunny4, bunny5, bunny6,
				cat1, cat2, cat3, cat4, cat5, cat6,
				turtle1, turtle2, turtle3, turtle4, turtle5, turtle6;
				
	//all sprites
	public Sprite bunny1_sprite, bunny2_sprite, bunny3_sprite, bunny4_sprite, bunny5_sprite, bunny6_sprite,
				cat1_sprite, cat2_sprite, cat3_sprite, cat4_sprite, cat5_sprite, cat6_sprite,
				turtle1_sprite, turtle2_sprite, turtle3_sprite, turtle4_sprite, turtle5_sprite, turtle6_sprite;
			
    // Start is called before the first frame update
    void Start()
    {
        //array of sprites
		Sprite[] sprites = {bunny1_sprite, bunny2_sprite, bunny3_sprite, bunny4_sprite, bunny5_sprite, bunny6_sprite,
				cat1_sprite, cat2_sprite, cat3_sprite, cat4_sprite, cat5_sprite, cat6_sprite,
				turtle1_sprite, turtle2_sprite, turtle3_sprite, turtle4_sprite, turtle5_sprite, turtle6_sprite};
			
        //update items in inventory
		updateItems(sprites);
    }
	
	//update items function
	void updateItems(Sprite[] sprites){
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
		int count = 0;
		foreach(Button button in buttons){
			if(PlayerPrefs.GetInt(button.name, 0) == 1){
				//the item is purchased, set image to corresponding sprite
				button.GetComponent<Image>().sprite = sprites[count];
			}else{
				//otherwise set image to empty slot
				button.GetComponent<Image>().sprite = emptySlot;
				//make the empty slot not interactable
				button.interactable = false;
			}
			count++;
		}
	}
}
