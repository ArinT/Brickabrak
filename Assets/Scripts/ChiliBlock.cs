using UnityEngine;
using System.Collections;

public class ChiliBlock : MonoBehaviour {

	public Sprite sprite;
	// Use this for initialization
	void Start () {
		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = sprite;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision)
	{
		GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>().chiliTime = Time.realtimeSinceStartup;
		Destroy (gameObject);
	}
}
