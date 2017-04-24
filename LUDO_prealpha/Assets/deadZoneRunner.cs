using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadZoneRunner : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D other){
		if (other) {
			SceneManager.LoadScene (2);
			Debug.Log (other.name.ToString () + " has hit me");
	
		}
	}
}
