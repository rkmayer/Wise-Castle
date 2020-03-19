/*
UpdateCharacterScript - checks playerprefs related to character model
and displays them accordingly

Ryan Mayer
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCharacterScript : MonoBehaviour
{
	//all character sprites
	public Sprite body_1, body_2, body_3, body_4, body_5,
							eyes_1, eyes_2, eyes_3, eyes_4,
							hair_1,
							mouth_1, mouth_2;
							
	//all item sprites
	public Sprite hat1black, hat1white, hat1red, hat1yellow, hat1green, hat1blue, hat1pink, hat1purple,
		hat2black, hat2white, hat2red, hat2yellow, hat2green, hat2blue, hat2pink, hat2purple,
		hat3black, hat3white, hat3red, hat3yellow, hat3green, hat3blue, hat3pink, hat3purple,
		robe1grey, robe1red, robe1blue, robe1green, robe1orange, robe1purple,
		robe2grey, robe2red, robe2blue, robe2green, robe2orange, robe2purple,
		robe3grey, robe3red, robe3blue, robe3green, robe3orange, robe3purple;
	
	//character slots
	public GameObject sprite_body, sprite_eyes, sprite_hair, sprite_mouth,
					sprite_hat, sprite_robe;
					//sprite_pet
	
    // Start is called before the first frame update
    void Start()
    {
		//get ids of items in each slot
		int body_id = PlayerPrefs.GetInt("PlayerBody", 1);
		int eyes_id = PlayerPrefs.GetInt("PlayerEyes", 1);
		int hair_id = PlayerPrefs.GetInt("PlayerHair", 1);
		int mouth_id = PlayerPrefs.GetInt("PlayerMouth", 1);
		
		int hat_id = PlayerPrefs.GetInt("PlayerHat", 1);
		int robe_id = PlayerPrefs.GetInt("PlayerRobe", 1);
		//int pet_id = PlayerPrefs.GetInt("PlayerAnimal", 1);
		
		//body
		switch(body_id){
			case(1):
			sprite_body.GetComponent<SpriteRenderer>().sprite = body_1;
			break;
			case(2):
			sprite_body.GetComponent<SpriteRenderer>().sprite = body_2;
			break;
			case(3):
			sprite_body.GetComponent<SpriteRenderer>().sprite = body_3;
			break;
			case(4):
			sprite_body.GetComponent<SpriteRenderer>().sprite = body_4;
			break;
			case(5):
			sprite_body.GetComponent<SpriteRenderer>().sprite = body_5;
			break;
		}
		
		//eyes
		switch(eyes_id){
			case(1):
			sprite_eyes.GetComponent<SpriteRenderer>().sprite = eyes_1;
			break;
			case(2):
			sprite_eyes.GetComponent<SpriteRenderer>().sprite = eyes_2;
			break;
			case(3):
			sprite_eyes.GetComponent<SpriteRenderer>().sprite = eyes_3;
			break;
			case(4):
			sprite_eyes.GetComponent<SpriteRenderer>().sprite = eyes_4;
			break;
		}
		
		//hair
		switch(hair_id){
			case(1):
			sprite_hair.GetComponent<SpriteRenderer>().sprite = hair_1;
			break;
		}
		
		//mouth
		switch(mouth_id){
			case(1):
			sprite_mouth.GetComponent<SpriteRenderer>().sprite = mouth_1;
			break;
			case(2):
			sprite_mouth.GetComponent<SpriteRenderer>().sprite = mouth_2;
			break;
		}
		
		//hat
		switch(hat_id){
			case(1):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1black;
			break;
			case(2):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1white;
			break;
			case(3):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1red;
			break;
			case(4):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1yellow;
			break;
			case(5):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1green;
			break;
			case(6):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1blue;
			break;
			case(7):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1pink;
			break;
			case(8):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat1purple;
			break;
			case(9):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2black;
			break;
			case(10):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2white;
			break;
			case(11):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2red;
			break;
			case(12):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2yellow;
			break;
			case(13):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2green;
			break;
			case(14):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2blue;
			break;
			case(15):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2pink;
			break;
			case(16):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat2purple;
			break;
			case(17):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3black;
			break;
			case(18):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3white;
			break;
			case(19):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3red;
			break;
			case(20):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3yellow;
			break;
			case(21):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3green;
			break;
			case(22):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3blue;
			break;
			case(23):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3pink;
			break;
			case(24):
			sprite_hat.GetComponent<SpriteRenderer>().sprite = hat3purple;
			break;
		}
		
		//robe
		switch(robe_id){
			case(1):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe1grey;
			break;
			case(2):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe1red;
			break;
			case(3):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe1blue;
			break;
			case(4):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe1green;
			break;
			case(5):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe1orange;
			break;
			case(6):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe1purple;
			break;
			case(7):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe2grey;
			break;
			case(8):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe2red;
			break;
			case(9):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe2blue;
			break;
			case(10):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe2green;
			break;
			case(11):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe2orange;
			break;
			case(12):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe2purple;
			break;
			case(13):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe3grey;
			break;
			case(14):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe3red;
			break;
			case(15):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe3blue;
			break;
			case(16):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe3green;
			break;
			case(17):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe3orange;
			break;
			case(18):
			sprite_robe.GetComponent<SpriteRenderer>().sprite = robe3purple;
			break;
		}
		
		//pet
    }
}
