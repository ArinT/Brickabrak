using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	// Use this for initialization
	int score;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		score = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>().score;
		guiText.text = score.ToString();
	}
}
