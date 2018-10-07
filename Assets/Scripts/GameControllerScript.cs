using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {

	public GameObject gameOverText;
	public bool gameOver = false;
	public static GameControllerScript instance;
	public float scrollSpeed = -1.5f;
	private int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Awake () {

		//singleton
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver && Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

    public void HeroScore(){
		if (gameOver)
		{
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString();

	}
	public void HeroDeath(){
       gameOverText.SetActive(true);
	   gameOver = true;
	}
}
