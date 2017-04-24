using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

	public Button goButton;
	public string levelString;

	// Use this for initialization
	void Start() {
//		SceneManager.LoadScene ("1. Game", LoadSceneMode.Single);

		Button btn = goButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	
	}


	void TaskOnClick(){
		SceneManager.LoadScene (levelString, LoadSceneMode.Single);

	}
	

}
