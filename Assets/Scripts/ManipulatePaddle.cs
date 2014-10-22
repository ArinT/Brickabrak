using UnityEngine;
using System.Collections;

public class ManipulatePaddle : MonoBehaviour {
	public Vector3 direction;
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal") > 0 ? 1 : (Input.GetAxis("Horizontal")<0? -1:0);
		Vector3 previous = transform.position;
		transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal")*speed*Time.deltaTime,transform.position.y, transform.position.z);
		if (Mathf.Abs(transform.position.x) > 16)
		{
			transform.position = previous;
		}
	}
}
