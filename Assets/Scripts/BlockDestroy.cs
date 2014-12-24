using UnityEngine;
using System.Collections;

public class BlockDestroy : MonoBehaviour {

	public int hitCounter;
	public Sprite spriteA;
	public Sprite spriteB;
	public SpriteRenderer spriteRenderer;
	public GameObject foodball;
	//public Texture textureA = Resources.Load("Textures/Grass");
	// Use this for initialization
	void Start () {
		hitCounter = 2;
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = spriteA;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.gameObject.tag=="Ball")
		{
			hitCounter--;
			if (hitCounter == 1) {
							spriteRenderer.sprite = spriteB;
					}
			if (hitCounter == 0) {
				if (Random.Range(0,100) > 66)
							{
								Instantiate(foodball, this.transform.position, this.transform.rotation);
							}
							Destroy (gameObject);
					}
			}
	}
}
