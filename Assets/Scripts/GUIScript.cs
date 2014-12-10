
//C#
using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {      
    void OnGUI () {
        // Make a background box
		int score = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>().score;

		Rect rect = new Rect(194,590, 100, 100);
		GUIStyle gui = new GUIStyle ();
		gui.alignment = TextAnchor.MiddleCenter;
		GUI.Box(rect, score.ToString(),gui);
    }
}