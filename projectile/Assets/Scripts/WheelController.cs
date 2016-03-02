using UnityEngine;
using System.Collections;

public class WheelController : MonoBehaviour {

	public Rigidbody2D wheel;

	public Collider2D ball;

	// Use this for initialization
	void Start () {

		wheel = this.GetComponent<Rigidbody2D> ();
	
	}

	void OnTriggerEnter2D (Collider2D ball){

		if (ball.tag == "ball") {

			wheel.WakeUp();

		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
