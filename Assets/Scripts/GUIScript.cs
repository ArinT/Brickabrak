
//C#
using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
            
    void OnGUI () {
        // Make a background box
		int score = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>().score;
        GUI.Box(new Rect(10,10,100,20), score.ToString());
    }
}