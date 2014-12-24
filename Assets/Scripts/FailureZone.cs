using UnityEngine;
using System.Collections;

public class FailureZone : MonoBehaviour {
	public bool fail = false;
	public ManipulateSphere script;
	public bool livesOn = false;
	// Use this for initialization
	void Start () {
		script = GameObject.FindGameObjectWithTag("Ball").GetComponent<ManipulateSphere>();
	}
	
	void OnTriggerEnter(Collider target)
	{
		if (target.collider.tag == "Ball") {
						fail = true;
						script.Reset ();
			if (livesOn) {GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>().death ();}
				}
		else if (target.collider.tag == "Foodball"){
			GameObject.Destroy(target.gameObject);
		}
	}
	void OnTriggerExit(Collider target)
	{
		if (target.collider.tag == "Ball") {
						fail = false;
				}
	}
	
}
