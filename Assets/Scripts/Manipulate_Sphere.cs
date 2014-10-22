using UnityEngine;
using System.Collections;
public class Manipulate_Sphere : MonoBehaviour {
	public float angle;
	public float x;
	public float z;
	public float minspeed = 20f;
	public float maxspeed = 30f;
	public float speed;
	public float multiplier = 1.01f;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = new Vector3(20,0,10);
	}

	void checkVerticalAngle ()
	{
		if (angle > 70 || angle < -70)
		{
			if (x > 0)
			{	
				rigidbody.velocity = new Vector3(rigidbody.velocity.x + 1,rigidbody.velocity.y, rigidbody.velocity.z);
			}
			else
			{
				rigidbody.velocity = new Vector3(rigidbody.velocity.x - 1 ,rigidbody.velocity.y, rigidbody.velocity.z);
			}
		}
	}
	void checkHorizontalAngle ()
	{
		if (angle < 20 && angle > -20)
		{
			if ( z > 0 )
			{
				rigidbody.velocity = new Vector3(rigidbody.velocity.x,rigidbody.velocity.y, rigidbody.velocity.z + 1);
			}
			else
			{
				rigidbody.velocity = new Vector3(rigidbody.velocity.x,rigidbody.velocity.y, rigidbody.velocity.z - 1);
			}
		}
	}
	void checkMinSpeed ()
	{
		if (rigidbody.velocity.magnitude < minspeed)
		{
			rigidbody.velocity = rigidbody.velocity/rigidbody.velocity.magnitude * minspeed *multiplier;
		}
	}

	void checkMaxSpeed ()
	{
		if (rigidbody.velocity.magnitude > maxspeed)
		{
			rigidbody.velocity = rigidbody.velocity/rigidbody.velocity.magnitude*maxspeed;
		}
	}

	
	
	// Update is called once per frame
	void Update () {
		checkMinSpeed ();
		x = rigidbody.velocity.x;
		z = rigidbody.velocity.z;
		angle = Mathf.Atan(z/x)*180/Mathf.PI;
		checkVerticalAngle ();
		checkHorizontalAngle ();
		checkMaxSpeed ();
		speed = rigidbody.velocity.magnitude;
	}
	void OnCollisionEnter(Collision collision)
	{
		rigidbody.velocity *= multiplier;
	}
	
}
