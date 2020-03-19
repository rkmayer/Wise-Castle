/*
CharacterEditScript - allows player to edit character features
(eg. skin colour, eyes, mouth, hair...) and save using
player prefs

Ryan Mayer
All robe sprites drawn by Jenna Magbanua
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterEditScript : MonoBehaviour
{
	//all character sprites
	public Sprite body_1, body_2, body_3, body_4, body_5,
							eyes_1, eyes_2, eyes_3, eyes_4,
							hair_1,
							mouth_1, mouth_2;
	//character slots
	public GameObject sprite_body, sprite_eyes, sprite_hair, sprite_mouth;
	//option buttons
	public Button body1, body2, body3, body4, body5,
						eyes1, eyes2, eyes3, eyes4,
						hair1,
						mouth1, mouth2;
	
    // Start is called before the first frame update
    void Start()
    {
		//listeners for buttons
		//body
		body1.onClick.AddListener(() => updateBody(1));
		body2.onClick.AddListener(() => updateBody(2));
		body3.onClick.AddListener(() => updateBody(3));
		body4.onClick.AddListener(() => updateBody(4));
		body5.onClick.AddListener(() => updateBody(5));
		
		//eyes
		eyes1.onClick.AddListener(() => updateEyes(1));
		eyes2.onClick.AddListener(() => updateEyes(2));
		eyes3.onClick.AddListener(() => updateEyes(3));
		eyes4.onClick.AddListener(() => updateEyes(4));
		
		//hair
		hair1.onClick.AddListener(() => updateHair(1));
		
		//mouth
		mouth1.onClick.AddListener(() => updateMouth(1));
		mouth2.onClick.AddListener(() => updateMouth(2));
		
		//update player preview
		updatePlayer();
    }
	
	//update function
	void updatePlayer(){
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
	
	//update player prefs
	//body
	void updateBody(int id){
		PlayerPrefs.SetInt("PlayerBody", id);
		updatePlayer();
	}
	//eyes
	void updateEyes(int id){
		PlayerPrefs.SetInt("PlayerEyes", id);
		updatePlayer();
	}
	//hair
	void updateHair(int id){
		PlayerPrefs.SetInt("PlayerHair", id);
		updatePlayer();
	}
	//mouth
	void updateMouth(int id){
		PlayerPrefs.SetInt("PlayerMouth", id);
		updatePlayer();
	}
}
