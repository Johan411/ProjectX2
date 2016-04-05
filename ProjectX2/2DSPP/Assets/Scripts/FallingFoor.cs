using UnityEngine;
using System.Collections;

public class FallingFoor : MonoBehaviour {

	public Collider2D player;

	public Rigidbody2D Floor;

	// Use this for initialization
	void Start () {

		Floor = this.GetComponent<Rigidbody2D> ();

	}

	void OnTriggerEnter2D(Collider2D player)
	{
		if(player.tag=="Player")
		{
			Floor.WakeUp();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
