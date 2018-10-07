using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	private bool isDead = false;
	private Rigidbody2D ourB2D;
	private Animator anim;

	public float upforce = 200f;

	// Use this for initialization
	void Start () {
		//get our rigidbody2D
		ourB2D = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isDead)
		{
			//left click
			if (Input.GetMouseButtonDown(0))
			{
				//flappy
				ourB2D.velocity = Vector2.zero;
				ourB2D.AddForce(new Vector2(0,upforce));
				anim.SetTrigger("Flap");
				//score
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		ourB2D.velocity = Vector2.zero;
		Debug.Log("is dead");
		isDead = true;
		anim.SetTrigger("Death");
		GameControllerScript.instance.HeroDeath();
	}
}
