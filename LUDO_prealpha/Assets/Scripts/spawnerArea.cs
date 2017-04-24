using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerArea : MonoBehaviour {

	public GameObject newObject;
	private Vector2 myZone;

	private int spawnCount = 0;
	private int spawnMax = 5;
	private float timeBetweenSpawns = 5.0f;

	// Use this for initialization
	void Start(){
		InvokeRepeating ("Spawn", 0, timeBetweenSpawns);
		Debug.Log ("spawnArea is empty make 5 copies");
	}

	void SetParent(GameObject newParent){
		transform.parent = newParent.transform;
	}


	void Spawn () {
//		GameObject clone;
		Instantiate (newObject, transform.parent);
//		SetParent (newObject);
		transform.position = Random.insideUnitCircle * 4;

		spawnCount++;
		if (spawnCount>=spawnMax) {
			CancelInvoke ();
		}
	}
	
	// Update is called once per frame
	void Update () {


	}

}
