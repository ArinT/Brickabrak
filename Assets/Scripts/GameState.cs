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
		if (GameObject.FindGameObjectsWithTag("Block").Length == 0)
		{
			Application.LoadLevel("EndGame");
		}
	}
}
