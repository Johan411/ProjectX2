using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	static LevelController instance;
	//public Collider2D player;
	public Collider2D object1;
	public int currLevel;
	public PlayerController playerScript;
	public GameObject player;
	// Use this for initialization
	void Start () {
		playerScript = FindObjectOfType<PlayerController> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}
public void reload()
	{ currLevel = Application.loadedLevel;
		Debug.Log ("ivideethi");
				Application.LoadLevel (1);

	}
	public void playerkill()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		Destroy (player.GetComponent<SpriteRenderer>());
		Destroy(player.GetComponent<Rigidbody2D>());
	}
	// Update is called once per frame
	void Update () {

	//	reload ();
	}
}
