using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerPlatformDestroyer : MonoBehaviour {

	public GameObject platformGarbagePoint;


	// Use this for initialization
	void Start () {
		platformGarbagePoint = GameObject.Find ("PlatformGarbagePoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < platformGarbagePoint.transform.position.x) {
//			Destroy (gameObject);
			gameObject.SetActive(false);
		}
	}
}
