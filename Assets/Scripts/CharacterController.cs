using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	public float maxSpeed = 10f;

	bool facingRight = true;

	Rigidbody2D rigidbody;
	Animator anim;

	// Use this for initialization
	void Start () {
		this.rigidbody = GetComponent<Rigidbody2D> ();
		this.anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		anim.SetFloat ("velocityX", moveX);
		anim.SetFloat ("velocityY", moveY);

		rigidbody.velocity = new Vector2 (
			moveX * maxSpeed,
			moveY * maxSpeed
		);

		if (moveX > 0 && !facingRight) {
			Flip ();
		} else if (moveX < 0 && facingRight) {
			Flip ();
		}
	}

	void Flip(){
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
