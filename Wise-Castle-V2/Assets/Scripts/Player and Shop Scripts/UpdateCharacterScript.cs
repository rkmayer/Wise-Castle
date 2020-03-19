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
							
	//character slots
	public GameObject sprite_body, sprite_eyes, sprite_hair, sprite_mouth;
	
    // Start is called before the first frame update
    void Start()
    {
		//get ids of items in each slot
		int body_id = PlayerPrefs.GetInt("PlayerBody", 1);
		int eyes_id = PlayerPrefs.GetInt("PlayerEyes", 1);
		int hair_id = PlayerPrefs.GetInt("PlayerHair", 1);
		int mouth_id = PlayerPrefs.GetInt("PlayerMouth", 1);
		
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
		switch(PlayerPrefs.GetInt("PlayerEyes", 1)){
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
		switch(PlayerPrefs.GetInt("PlayerHair", 1)){
			case(1):
			sprite_hair.GetComponent<SpriteRenderer>().sprite = hair_1;
			break;
		}
		
		//mouth
		switch(PlayerPrefs.GetInt("PlayerMouth", 1)){
			case(1):
			sprite_mouth.GetComponent<SpriteRenderer>().sprite = mouth_1;
			break;
			case(2):
			sprite_mouth.GetComponent<SpriteRenderer>().sprite = mouth_2;
			break;
		}
    }
}
