using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : gameManager {


//	public GameObject wormScript;

	private Text displayT;
//	private int wormTimeScore;
	private bool timeIsActive;
//	private int gmScore;

	// Use this for initialization
	void Start () {
//		gmScore = scoreInt;
		timeIsActive = true;
		displayT = GetComponent<Text> ();
		displayT.text = "0";
	}

	public void scoreUpdate(){
		if (timeIsActive) {
//			wormTimeScore = Time.fixedTime.ToString ("0");
//			displayT.text = "" + scoreTotal.ToString ();
//			Debug.Log ("display this score: " + scoreTotal);
		}
	}

	// Update is called once per frame
	void Update () {

		scoreUpdate ();

	}
}
