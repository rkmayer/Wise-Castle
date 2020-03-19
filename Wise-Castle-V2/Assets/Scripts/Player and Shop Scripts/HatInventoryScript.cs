using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatInventoryScript : MonoBehaviour
{	
	//empty slot sprite
	[SerializeField] public Sprite emptySlot;
	
	//retrieve all buttons (inventory items)
	public Button hat1black, hat1white, hat1red, hat1yellow, hat1green, hat1blue, hat1pink, hat1purple,
		hat2black, hat2white, hat2red, hat2yellow, hat2green, hat2blue, hat2pink, hat2purple,
		hat3black, hat3white, hat3red, hat3yellow, hat3green, hat3blue, hat3pink, hat3purple;
		
	//all sprites
	public Sprite hat1black_sprite, hat1white_sprite, hat1red_sprite, hat1yellow_sprite, hat1green_sprite, hat1blue_sprite, hat1pink_sprite, hat1purple_sprite,
			hat2black_sprite, hat2white_sprite, hat2red_sprite, hat2yellow_sprite, hat2green_sprite, hat2blue_sprite, hat2pink_sprite, hat2purple_sprite,
			hat3black_sprite, hat3white_sprite, hat3red_sprite, hat3yellow_sprite, hat3green_sprite, hat3blue_sprite, hat3pink_sprite, hat3purple_sprite;
	
    // Start is called before the first frame update
    void Start()
    {
		//array of sprites
		Sprite[] sprites = {hat1black_sprite, hat1white_sprite, hat1red_sprite, hat1yellow_sprite, hat1green_sprite, hat1blue_sprite, hat1pink_sprite, hat1purple_sprite,
			hat2black_sprite, hat2white_sprite, hat2red_sprite, hat2yellow_sprite, hat2green_sprite, hat2blue_sprite, hat2pink_sprite, hat2purple_sprite,
			hat3black_sprite, hat3white_sprite, hat3red_sprite, hat3yellow_sprite, hat3green_sprite, hat3blue_sprite, hat3pink_sprite, hat3purple_sprite};
			
        //update items in inventory
		updateItems(sprites);
    }
	
	//update items function
	void updateItems(Sprite[] sprites){
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
