using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	static LevelController instance;
	//public Collider2D player;
	public Collider2D object1;
	public int currLevel;
	public PlayerController playerScript;
	public GameObject player;
	public float deathDelay=1.0f;
	// Use this for initialization
	void Start () {
		playerScript = FindObjectOfType<PlayerController> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	public IEnumerator reload()
	{ 	
		currLevel = Application.loadedLevel;
		//Application.LoadLevel (currLevel);
		yield return new WaitForSeconds (deathDelay);

				Application.LoadLevel (currLevel);

	}
	public void playerkill()
	{Debug.Log ("ivideethi");
		player = GameObject.FindGameObjectWithTag ("Player");
		Destroy (player.GetComponent<SpriteRenderer>());
		Destroy(player.GetComponent<Rigidbody2D>());
		Destroy (playerScript);
		Debug.Log ("ivideethi1");
		StartCoroutine ("reload");

	}
	// Update is called once per frame
	void Update () {

	//	reload ();
	}
}
