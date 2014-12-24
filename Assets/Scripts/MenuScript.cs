using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	public int pos = 0;
	public AudioSource cancel;
	public AudioSource confirm;
	public AudioSource move;

	public Sprite[] menu_sprites = new Sprite[3];
	/*
	 * 0 = Play
	 * 1 = Controls
	 * 2 = Credits
	 */
	void Start () {
		pos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			pos++;pos = pos%3;
			move.Play();
		}
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			pos--;
			pos = pos<0?pos+3:pos;
			move.Play();
		}
		else if (Input.GetButtonDown ("Submit")){
			if (pos == 0)
			{
				confirm.Play ();
				Application.LoadLevel("Level 2 V1");
			}
		}
		GetComponent<UnityEngine.UI.Image> ().sprite = menu_sprites[pos];
	}
}
