using UnityEngine;
using System.Collections;

public class FailureZone : MonoBehaviour {
	public bool fail = false;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider target)
	{
		if (target.tag == "Ball")
			fail = true;
	}
	void OnTriggerExit(Collider target)
	{
		if (target.tag == "Ball")
			fail = false;
	}
	
}
