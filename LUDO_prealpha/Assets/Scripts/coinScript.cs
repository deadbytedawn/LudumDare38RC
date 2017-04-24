using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : gameManager {


	private bool activeCoin;
	public int myValue = 3;
	public int myHealth = 10;
	public int AC= 1;

	public GameObject hitMarker;

	void Awake(){
		activeCoin = true;

	}

	void OnTriggerEnter2D(Collider2D other){
		if (activeCoin) {
			if (myHealth > 0) {
				myHealth -= AC;
				GameObject hit = Instantiate (hitMarker, other.transform.position, Quaternion.identity) as GameObject;

			}
			if (myHealth <= 0) {
	
				gameObject.SetActive (false);
				activeCoin = false;
				AddPoints (myValue);
	
			}

		}
	}
}
