using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerManager : CountdownTimer {


	private int bottom =0;
	public string levelLoad;

	private CountdownTimer countdownTimer;
//	private Slider sliderUI;
	private int startSeconds = 30;

	void Start(){
//		SetupSlider ();
		SetupTimer ();
	}


//	private void SetupSlider(){
//		sliderUI = GetComponent<Slider> ();
//		sliderUI.minValue = 0;
//		sliderUI.maxValue = 1;
//		sliderUI.wholeNumbers = false;
//	}

	private void SetupTimer(){
		countdownTimer = GetComponent<CountdownTimer> ();
		countdownTimer.ResetTimer (startSeconds);
	}

	void Update(){
		if (countdownTimer.GetSecondsRemaining() == bottom) {
			SceneManager.LoadScene (levelLoad);
		}
	}
}
