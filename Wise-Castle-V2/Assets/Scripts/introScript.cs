using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introScript : MonoBehaviour
{
    public Button introBtn;
	
	void Start(){
		introBtn.onClick.AddListener(loadIntro);
	}
	
    void loadIntro()
    {
		SceneManager.LoadScene("tutorial_firstRun");
    }
}
