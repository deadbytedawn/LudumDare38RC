using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class CountdownTimer : MonoBehaviour {


	private float countdownTimerStartTime;
	protected int countdownTimerDuration;

	//-----------------------------
	public int GetTotalSeconds()
	{
		return countdownTimerDuration;
	}

	//-----------------------------
	public void ResetTimer(int seconds)
	{
		countdownTimerStartTime = Time.time;
		countdownTimerDuration = seconds;
	}

	//-----------------------------
	public int GetSecondsRemaining()
	{
		int elapsedSeconds = (int)(Time.time - countdownTimerStartTime);
		int secondsLeft = (countdownTimerDuration - elapsedSeconds);
		return secondsLeft;
	}

	//-----------------------------
	public float GetProportionTimeRemaining()
	{
		float proportionLeft = (float)GetSecondsRemaining() / (float)GetTotalSeconds();
		return proportionLeft;
	}
}
