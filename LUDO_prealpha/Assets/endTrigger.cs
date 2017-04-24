using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endTrigger : MonoBehaviour{

	public string levelString;

	// Use this for initialization
	void Start() {
		//		SceneManager.LoadScene ("1. Game", LoadSceneMode.Single);


	}


	void OnTriggerEnter2D(){
		SceneManager.LoadScene (levelString, LoadSceneMode.Single);

	}


}