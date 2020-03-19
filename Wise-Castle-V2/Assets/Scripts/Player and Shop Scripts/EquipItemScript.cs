/*
EquipItemScript - allows player to equip an item
they have purchased from their inventory

Ryan Mayer
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//robe1grey, robe1red, robe1blue, robe1green, robe1orange, robe1purple,
		//robe2grey, robe2red, robe2blue, robe2green, robe2orange, robe2purple,
		//robe3grey, robe3red, robe3blue, robe3green, robe3orange, robe3purple

public class EquipItemScript : MonoBehaviour
{
    public void updateCharacter(string id){
		switch(id){
			//hats
			case("hat1black"):
			PlayerPrefs.SetInt("PlayerHat", 1);
			break;
			case("hat1white"):
			PlayerPrefs.SetInt("PlayerHat", 2);
			break;
			case("hat1red"):
			PlayerPrefs.SetInt("PlayerHat", 3);
			break;
			case("hat1yellow"):
			PlayerPrefs.SetInt("PlayerHat", 4);
			break;
			case("hat1green"):
			PlayerPrefs.SetInt("PlayerHat", 5);
			break;
			case("hat1blue"):
			PlayerPrefs.SetInt("PlayerHat", 6);
			break;
			case("hat1pink"):
			PlayerPrefs.SetInt("PlayerHat", 7);
			break;
			case("hat1purple"):
			PlayerPrefs.SetInt("PlayerHat", 8);
			break;
			case("hat2black"):
			PlayerPrefs.SetInt("PlayerHat", 9);
			break;
			case("hat2white"):
			PlayerPrefs.SetInt("PlayerHat", 10);
			break;
			case("hat2red"):
			PlayerPrefs.SetInt("PlayerHat", 11);
			break;
			case("hat2yellow"):
			PlayerPrefs.SetInt("PlayerHat", 12);
			break;
			case("hat2green"):
			PlayerPrefs.SetInt("PlayerHat", 13);
			break;
			case("hat2blue"):
			PlayerPrefs.SetInt("PlayerHat", 14);
			break;
			case("hat2pink"):
			PlayerPrefs.SetInt("PlayerHat", 15);
			break;
			case("hat2purple"):
			PlayerPrefs.SetInt("PlayerHat", 16);
			break;
			case("hat3black"):
			PlayerPrefs.SetInt("PlayerHat", 17);
			break;
			case("hat3white"):
			PlayerPrefs.SetInt("PlayerHat", 18);
			break;
			case("hat3red"):
			PlayerPrefs.SetInt("PlayerHat", 19);
			break;
			case("hat3yellow"):
			PlayerPrefs.SetInt("PlayerHat", 20);
			break;
			case("hat3green"):
			PlayerPrefs.SetInt("PlayerHat", 21);
			break;
			case("hat3blue"):
			PlayerPrefs.SetInt("PlayerHat", 22);
			break;
			case("hat3pink"):
			PlayerPrefs.SetInt("PlayerHat", 23);
			break;
			case("hat3purple"):
			PlayerPrefs.SetInt("PlayerHat", 24);
			break;
			//robes
			case("robe1grey"):
			PlayerPrefs.SetInt("PlayerRobe", 1);
			break;
			case("robe1red"):
			PlayerPrefs.SetInt("PlayerRobe", 2);
			break;
			case("robe1blue"):
			PlayerPrefs.SetInt("PlayerRobe", 3);
			break;
			case("robe1green"):
			PlayerPrefs.SetInt("PlayerRobe", 4);
			break;
			case("robe1orange"):
			PlayerPrefs.SetInt("PlayerRobe", 5);
			break;
			case("robe1purple"):
			PlayerPrefs.SetInt("PlayerRobe", 6);
			break;
			case("robe2grey"):
			PlayerPrefs.SetInt("PlayerRobe", 7);
			break;
			case("robe2red"):
			PlayerPrefs.SetInt("PlayerRobe", 8);
			break;
			case("robe2blue"):
			PlayerPrefs.SetInt("PlayerRobe", 9);
			break;
			case("robe2green"):
			PlayerPrefs.SetInt("PlayerRobe", 10);
			break;
			case("robe2orange"):
			PlayerPrefs.SetInt("PlayerRobe", 11);
			break;
			case("robe2purple"):
			PlayerPrefs.SetInt("PlayerRobe", 12);
			break;
			case("robe3grey"):
			PlayerPrefs.SetInt("PlayerRobe", 13);
			break;
			case("robe3red"):
			PlayerPrefs.SetInt("PlayerRobe", 14);
			break;
			case("robe3blue"):
			PlayerPrefs.SetInt("PlayerRobe", 15);
			break;
			case("robe3green"):
			PlayerPrefs.SetInt("PlayerRobe", 16);
			break;
			case("robe3orange"):
			PlayerPrefs.SetInt("PlayerRobe", 17);
			break;
			case("robe3purple"):
			PlayerPrefs.SetInt("PlayerRobe", 18);
			break;
		}
	}
}
