using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
	public int score;
	public int lives;
	public bool gameOver;
	public float chiliDuration = 10.0f;
	public float chiliTime;
	public bool isChili;
	// Use this for initialization
	void Start () {
		chiliTime = -10;
		score = 0;
		lives = 3;
		gameOver = false;
	}
	public void increaseScore ()
	{
		score+=100;
	}
	public void death()
	{
		lives--;
	}
	// Update is called once per frame
	void Update () {
		isChili = Time.realtimeSinceStartup - chiliTime < 10;
		if (GameObject.FindGameObjectsWithTag("Block").Length == 0)
		{
			Application.LoadLevel("EndGame");
		}
		else if (lives <= 0)
		{	
			Application.LoadLevel("EndGame");
		}
	}
}
