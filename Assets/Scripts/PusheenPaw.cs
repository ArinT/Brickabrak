using UnityEngine;
using System.Collections;

public class PusheenPaw : MonoBehaviour {

	GameObject paw;
	public double tParam = 1f;
	public float frames = 6f;
	float increment= .1f;
	public bool trigger = false;
	public int startPos = 18;
	public int endPos = 24;
	public float pos;
	// Use this for initialization
	void Start () {
		paw = GameObject.FindGameObjectWithTag ("PusheenPaw");
		increment = 1.0f / frames;
	}
	
	// Update is called once per frame
	void Update () {
		if (trigger) {
						tParam = tParam < 1.0f ? tParam + increment : tParam;		
				} else {
						tParam = tParam > 0.0f ? tParam - increment : tParam;
				}

		pos = Mathf.Lerp((float)startPos, (float)endPos, (float)tParam);
		paw.transform.position = new Vector3(paw.transform.position.x,paw.transform.position.y, pos);

		trigger = true;
	}
	void OnTriggerStay(Collider collider)
	{
		if (collider.tag == "Ball" || collider.tag == "Foodball")
		{
			trigger = false;
		}
	}
	//void OnTriggerExit(Collider collision)
	//{
	//	if (collider.tag == "Ball")
	//	{
	//		trigger = false;
	//	}
	//}

}
