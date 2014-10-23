using UnityEngine;
using System.Collections;
public class ManipulateSphere : MonoBehaviour {
	public float angle;
	float x;
	float z;
	float minspeed = 20f;
	float maxspeed = 30f;
	float multiplier = 1.01f;
	public AudioSource wallAudio;
	public AudioSource paddleAudio;
	public AudioSource blockAudio;
	public GameObject gameController;
	public bool fail;
	// Use this for initialization
	void Start () {
		fail = false;
		rigidbody.velocity = new Vector3(generateRandom(),0,20);
		gameController = GameObject.FindGameObjectWithTag("GameController");
	}
	int generateRandom()
	{
		return (int)(Random.value*40-20);
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

	
	public void Reset()
	{
		Vector3 position = GameObject.FindGameObjectWithTag("Player").transform.position;
		position.z += 2;
		transform.position = position;
		rigidbody.velocity = new Vector3(generateRandom(),0, 20);
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
	}
	void OnCollisionEnter(Collision collision)
	{
		rigidbody.velocity *= multiplier;
		switch (collision.collider.tag)
		{
		case "Wall":
			wallAudio.Play();
			break;
		case "Player":
			paddleAudio.Play ();
			break;
		case "Block":
			blockAudio.Play();
			gameController.GetComponent<GameState>().increaseScore();
			break;
		}
	}
	
}
