using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour {
	public float velocity=1f;
	public Transform sighStart;
	public Transform sightEnd;
	public bool colliding;
	public int xa = 0;
	public int count=0;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Hyd") {
			if (count == 0) {
				Debug.Log ("dead");
				//Application.LoadLevel (0);
				xa = 1;
				count = 1;
			}
			else if(count==1)
			{xa=0;count=0;}
		}
	}

	
	// Update is called once per frame
	void Update () {


		if (xa == 1) {
			//if (count > 200) {
				///transform.localScale = new Vector2 (-transform.localScale.x, transform.localScale.y);
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocity, GetComponent<Rigidbody2D> ().velocity.y);
		//	count++;
		}
			//if (count > 400)
			//	count = 0;
		 else {
			//count++;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocity, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
	/*void OnCollisionEnter(Collision col) {
		//Destroy(other.gameObject);
		
		if (col.gameObject.tag == "Hyd") {
		/*	GetComponent<Rigidbody2D> ().velocity = new Vector2 (-velocity, GetComponent<Rigidbody2D> ().velocity.y);
			transform.localScale=new Vector2(transform.localScale.x*-1,GetComponent<Rigidbody2D> ().velocity.y);*/
			//xa=1;

	/*	}
	}*/

}
