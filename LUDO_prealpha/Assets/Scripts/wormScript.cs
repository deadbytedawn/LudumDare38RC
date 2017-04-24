using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormScript : MonoBehaviour {

	private float timeCounter = 0.07f;
	private float trailTime = 0.08f;
//	private float fader = 0.1f;
	public bool istrailing = false;

	public LayerMask whatIsGround;
	public bool grounded;
	private Collider2D myCollider;


//	private Animator m_Anim;

	public GameObject spriteBody;
//	public SpriteRenderer spriteRender;

	// track score based on time (move to game manager!!!!)
//	public static string publicWormTime;
//	protected static string timeToScore; 


//	public static void moveTimeScale(string time){
//		timeToScore = Time.fixedTime.ToString();
//	}

	// Use this for initialization
	void Awake () {
		myCollider = GetComponent<Collider2D> ();
//		moveTimeScale ();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);

		Vector2 moveDirection = gameObject.GetComponent<Rigidbody2D> ().velocity;
		if (moveDirection != Vector2.zero) {
			float angle = Mathf.Atan2 (moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
			istrailing = true;

		} if(moveDirection == Vector2.zero){
			istrailing = false;

			Debug.Log("I stopped Moving.");

		}
		if (!grounded) {
			transform.position = Vector2.zero;
		}
		if (istrailing) {
			timeCounter += Time.deltaTime;
			if (timeCounter >= trailTime) {
				timeCounter = 0;
//				GameObject f = Instantiate (fader, new Vector3 (transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity) as GameObject;
				GameObject f = Instantiate(spriteBody, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity) as GameObject;
//				SpriteRenderer faderSprite = f.GetComponent<SpriteRenderer> ();
//				f.sprite = spriteRender.sprite;
//				f.transform.parent = gameObject.transform;
//	
			}
		}


	}
}
