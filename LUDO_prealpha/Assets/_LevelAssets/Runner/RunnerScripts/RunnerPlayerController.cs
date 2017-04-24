using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerPlayerController : MonoBehaviour
{

	public float moveSpeed;
	public float jumpForce;
	public float doubleJumpForce;


	public GameObject parentBody;
	public GameObject spriteBody;

	private float timeCounter = 0.04f;
	private float trailTime = 0.05f;
	public bool istrailing = false;

	private Rigidbody2D myRigidBody;

	private Collider2D myCollider;

	public bool grounded;
	public LayerMask whatIsGround;
	private bool doubleJump;

	private Animator m_Animator;

	//	public GameObject parentBody;
	 
	// Use this for initialization
	void Start ()
	{
//		parentBody = GameObject.Find ("BodyParent");
		myRigidBody = GetComponent<Rigidbody2D> ();
		myCollider = GetComponent<Collider2D> ();
		m_Animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);

		myRigidBody.velocity = new Vector2 (moveSpeed, myRigidBody.velocity.y);

		if (Input.GetButtonDown ("Jump")) {  // working????
			if (grounded) {
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, jumpForce);

					doubleJump = true;

			}


			if (doubleJump && !grounded && Input.GetButtonDown ("Jump")) {
				Debug.Log ("is 2x JUMP possible: " + doubleJump.ToString ());
				myRigidBody.AddForceAtPosition (Vector2.up*doubleJumpForce,myRigidBody.position,ForceMode2D.Impulse);
				doubleJump = false;		
			}

		}

		// BODY TRAIL
		if (istrailing) {
			timeCounter += Time.deltaTime;
			if (timeCounter >= trailTime) {
				timeCounter = 0;
				Instantiate (spriteBody, new Vector3 (transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity);

				//				GameObject f = Instantiate(spriteBody, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity) as GameObject;
				//				f.transform.parent = parentBody.transform;
			}
		}


		m_Animator.SetFloat ("Speed", myRigidBody.velocity.x);
		m_Animator.SetBool ("Grounded", grounded);
	}
}
