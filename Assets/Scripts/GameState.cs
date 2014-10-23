using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
	public int score;
	public int lives;
	public bool gameOver;
	// Use this for initialization
	void Start () {
		score = 0;
		lives = 3;
		gameOver = false;
	}
	public void endGame()
	{
		gameOver = true;
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
		if (gameOver)
		{
			Debug.Log("End");
			Application.LoadLevel("EndGame");
		}
	}
}
