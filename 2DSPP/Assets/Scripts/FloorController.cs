using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private PlayerController player;

	// Use this for initialization

	void OnTriggerEnter(Collider col) {
		//Destroy(other.gameObject);
		
		if (col.gameObject.name == "Player") {
			
			player.isGrounded = true;
			
		} else
			
			player.isGrounded = false;
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
