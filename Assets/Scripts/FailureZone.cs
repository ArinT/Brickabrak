using UnityEngine;
using System.Collections;

public class FailureZone : MonoBehaviour {
	public bool fail = false;
	public ManipulateSphere script;
	// Use this for initialization
	void Start () {
		script = GameObject.FindGameObjectWithTag("Ball").GetComponent<ManipulateSphere>();
	}
	
	void OnTriggerEnter(Collider target)
	{
		if (target.collider.tag == "Ball") {
						fail = true;
						script.Reset ();
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
