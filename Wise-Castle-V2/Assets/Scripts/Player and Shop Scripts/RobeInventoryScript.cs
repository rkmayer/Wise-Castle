using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobeInventoryScript : MonoBehaviour
{
	//empty slot sprite
	[SerializeField] public Sprite emptySlot;
	
	//retrieve all buttons (inventory items)
	public Button robe1grey, robe1red, robe1blue, robe1green, robe1orange, robe1purple,
		robe2grey, robe2red, robe2blue, robe2green, robe2orange, robe2purple,
		robe3grey, robe3red, robe3blue, robe3green, robe3orange, robe3purple;
		
	//all sprites
	public Sprite robe1grey_sprite, robe1red_sprite, robe1blue_sprite, robe1green_sprite, robe1orange_sprite, robe1purple_sprite,
		robe2grey_sprite, robe2red_sprite, robe2blue_sprite, robe2green_sprite, robe2orange_sprite, robe2purple_sprite,
		robe3grey_sprite, robe3red_sprite, robe3blue_sprite, robe3green_sprite, robe3orange_sprite, robe3purple_sprite;
			
    // Start is called before the first frame update
    void Start()
    {
        //array of sprites
		Sprite[] sprites = {robe1grey_sprite, robe1red_sprite, robe1blue_sprite, robe1green_sprite, robe1orange_sprite, robe1purple_sprite,
		robe2grey_sprite, robe2red_sprite, robe2blue_sprite, robe2green_sprite, robe2orange_sprite, robe2purple_sprite,
		robe3grey_sprite, robe3red_sprite, robe3blue_sprite, robe3green_sprite, robe3orange_sprite, robe3purple_sprite};
			
        //update items in inventory
		updateItems(sprites);
    }
	
	//update items function
	void updateItems(Sprite[] sprites){
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
