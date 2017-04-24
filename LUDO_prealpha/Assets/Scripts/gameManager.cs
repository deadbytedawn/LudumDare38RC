using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour {

	bool timed = false;

	void Start(){
		DontDestroyOnLoad (gameObject);
//		timed = true;
	}

	/// <summary>
	/// Example of how to add points from a game object.
	/// </summary>
	/// <remarks>Can call from button in inspector</remarks>
	/// <param name="points">Number of points to add (negative to subtract)</param>
	public void AddPoints(int points) {
		SumScore.Add(points);
	}

	/// <summary>
	/// Example of how to subtract points from a game object.
	/// </summary>
	/// <remarks>Can call from button in inspector</remarks>
	/// <param name="points">Number of points to subtract from score</param>
	public void SubtractPoints (int points) {
		SumScore.Add(-points);
		// NOTE - You can also use SumScore.Subtract(points) if you like typing
	}

	/// <summary>
	/// Toggles adding score based on time
	/// </summary>
	/// <remarks>Can call from button in inspector.</remarks>
	public void ToggleTimed () {
		timed = !timed;
	}

	/// <summary>Resets score to zero</summary>
	/// <remarks>Can call from button in inspector</remarks>
	public void ResetPoints () {
		SumScore.Reset();
	}

	/// <summary>Save if current score is greater than high score</summary>
	public void CheckHighScore () {
		if (SumScore.Score > SumScore.HighScore)
			SumScore.SaveHighScore();
	}

	/// <summary>Resets high score to zero</summary>
	/// <remarks>Can call from button in inspector</remarks>
	public void ClearHighScore () {
		SumScore.ClearHighScore();
	}

	void Update () {
		if (timed) 
			// Use Time.deltaTime to create a steady addition of points.
			// This example would add 100 points per second
			SumScore.Add(Mathf.RoundToInt(Time.deltaTime * 100));
	}






//	[SerializeField]
//	protected int scoreTotal;
//
//	[SerializeField]
//	protected int scoreBonus;
//
//	private int scoreKeeper;
//	private int scoreCollect;
//	private int scoreMinus;
//
//	private Vector3 spawnPos;
//
//	public Text scoreText;
//
//	// Use this for initialization
//	void Awake () {
//
//		DontDestroyOnLoad (this.gameObject);
//		scoreTotal += scoreKeeper;
//		scoreKeeper = 1;
//	}
//
//	public void AddScore(int scoreAddition){
//		scoreTotal += scoreAddition;
//		myScore ();
//	}
//
//	public void myScore(){
//		scoreText.text = "" + scoreTotal;
//	}
//
//	// Update is called once per frame
//	void Update () {
//
//		myScore ();
//
//	}
}
