using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugScript : MonoBehaviour
{
	public void resetAllItems(){
		//array of items
		string[] items = {"hat1black", "hat1white", "hat1red", "hat1yellow", "hat1green", "hat1blue", "hat1pink", "hat1purple",
			"hat2black", "hat2white", "hat2red", "hat2yellow", "hat2green", "hat2blue", "hat2pink", "hat2purple",
			"hat3black", "hat3white", "hat3red", "hat3yellow", "hat3green", "hat3blue", "hat3pink", "hat3purple"};
		
		//go through buttons checking for purchase flags
		foreach(string item in items){
			PlayerPrefs.SetInt(item, 0);
		}
	}
	
}
