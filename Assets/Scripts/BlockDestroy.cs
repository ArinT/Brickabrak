using UnityEngine;
using System.Collections;

public class BlockDestroy : MonoBehaviour {

	public int hitCounter;
	public Texture textureA;
	public Texture textureB;
	public MeshRenderer currentRenderer;
	//public Texture textureA = Resources.Load("Textures/Grass");
	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = textureA;
		currentRenderer = GetComponent<MeshRenderer>();
		currentRenderer.material.SetTexture("_MainTex", textureA);
		hitCounter = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision)
	{
		hitCounter--;
		if (hitCounter == 1)
			currentRenderer.material.SetTexture("_MainTex", textureB);
		if (hitCounter == 0)
			Destroy(gameObject);
	}
}
