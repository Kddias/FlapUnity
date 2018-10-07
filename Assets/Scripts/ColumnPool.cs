using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {



	public float spawnRate = 4f;
	public int columnPoolSize = 5;
	public GameObject columnprefab;

    //offsets
	public float columMin = -1.3f;
	public float columMax = 2.9f;

	//offscreen
	private Vector2 objectPoolPosition = new Vector2(-15f,-25f);
	private float timeSinceLastSpawned;
	private GameObject[] columns;
	
	private float spawnXPosition = 13f;
	private int currentColumns = 0;
	

	// Use this for initialization
	void Start () {
		columns = new GameObject[columnPoolSize];
		for (int i = 0; i < columnPoolSize; i++)
		{
			columns[i] = (GameObject) Instantiate(columnprefab,objectPoolPosition,Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawned += Time.deltaTime;

		if (!GameControllerScript.instance.gameOver && timeSinceLastSpawned >= spawnRate)
		{
			timeSinceLastSpawned = 0f; 
			float spawnYPosition = Random.Range(columMin,columMax);

			columns[currentColumns].transform.position = new Vector2(spawnXPosition,spawnYPosition);
			currentColumns++;
			if (currentColumns>= columnPoolSize)
			{
				currentColumns = 0;
			}					
		}
	}
}
