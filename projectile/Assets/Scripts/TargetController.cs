using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour {

	public float target_speed = 0.5f;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		//if ( Input.GetKey(KeyCode(
	
	}

	void FixedUpdate (){

		if (Input.GetKey ("left")) {

			transform.Translate (-(target_speed), 0, 0);

		}

		if (Input.GetKey ("right")) {

			transform.Translate (target_speed, 0, 0);

		}

		if (Input.GetKey ("e")) {



		}
	}
}
