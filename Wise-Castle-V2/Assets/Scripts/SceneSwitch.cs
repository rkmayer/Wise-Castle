﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
	public void LoadMainScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayBGMusic();
		SceneManager.LoadScene("main");
	}
	
	public void LoadTutorialFirstRun(){
		SceneManager.LoadScene("tutorial_firstRun");
	}
    public void LoadArtRabbitScene(){
		SceneManager.LoadScene("art_rabbit");
    }

    public void LoadArtSwanScene()
    {
        SceneManager.LoadScene("art_swan");
    }

    public void LoadArtLionScene()
    {
        SceneManager.LoadScene("art_lion");
    }

    public void LoadArtSelectionScene()
    {
        SceneManager.LoadScene("art_shapeselect");
    }

    public void LoadEnglishScene(){
		SceneManager.LoadScene("english");
    }

	public void LoadChemScene(){
		SceneManager.LoadScene("chemistry");
	}
	
	public void LoadMathScene(){
		SceneManager.LoadScene("math");
	}
	
	public void LoadSettingsScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("settings");
	}
	
	public void LoadPlayerScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("player");
	}
	
	public void LoadEditPlayerScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("player_edit");
	}
	
	public void LoadPlayerInventory(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("player_inventory");
	}
	
	public void LoadHatInventory(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("hat_inventory");
	}
	
	public void LoadRobeInventory(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("robe_inventory");
	}
	
	public void LoadAnimalInventory(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("animal_inventory");
	}
	
	public void LoadShopScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("shop");
	}
	
	public void LoadHatShopScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("shop_hats");
	}
	
	public void LoadRobeShopScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("shop_robes");
	}
	
	public void LoadAnimalShopScene(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("shop_animals");
	}
	
	public void LoadArtTutorial(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("tutorial_art");
	}
	
	public void LoadChemTutorial(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("tutorial_chem");
	}
	
	public void LoadEnglishTutorial(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("tutorial_english");
	}
	
	public void LoadMathTutorial(){
		GameObject.FindGameObjectWithTag("music").GetComponent<MusicScript>().PlayConfirmSound();
		SceneManager.LoadScene("tutorial_math");
	}
}