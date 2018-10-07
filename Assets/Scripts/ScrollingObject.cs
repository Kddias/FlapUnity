using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	private Rigidbody2D ourRB2D;

	// Use this for initialization
	void Start () {
		ourRB2D = GetComponent<Rigidbody2D>();
		ourRB2D.velocity = new Vector2(GameControllerScript.instance.scrollSpeed,0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControllerScript.instance.gameOver)
		{
			//stops on gameOver
			ourRB2D.velocity = Vector2.zero;
		}
	}
}
