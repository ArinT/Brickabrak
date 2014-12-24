using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	
	SpriteRenderer liveOne;
	SpriteRenderer liveTwo;
	SpriteRenderer liveThree;
	public Sprite onSprite;
	public Sprite offSprite;
	public int lives;

	// Use this for initialization
	void Start () {
		liveOne = GameObject.FindGameObjectWithTag ("Live1").GetComponent<SpriteRenderer> ();
		liveTwo = GameObject.FindGameObjectWithTag ("Live2").GetComponent<SpriteRenderer> ();
		liveThree = GameObject.FindGameObjectWithTag ("Live3").GetComponent<SpriteRenderer> ();
		lives = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameState> ().lives;
	}
	
	// Update is called once per frame
	void Update () {
		lives = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameState> ().lives;
		if (lives >= 3)
		{
			liveOne.sprite = onSprite;
			liveTwo.sprite = onSprite;
			liveThree.sprite = onSprite; 
		}
		else if (lives ==2){
			liveOne.sprite = onSprite;
			liveTwo.sprite = onSprite;
			liveThree.sprite = offSprite; 
		}
		else if (lives ==1){
			liveOne.sprite = onSprite;
			liveTwo.sprite = offSprite;
			liveThree.sprite = offSprite; 
		}
		else{
			liveOne.sprite = offSprite;
			liveTwo.sprite = offSprite;
			liveThree.sprite = offSprite; 
		}
	}
}
