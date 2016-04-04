using UnityEngine;
using System.Collections;

public class TimeTravel : MonoBehaviour {
	public GameObject player;
	public GameObject father;
	public bool camera2;
	public int count;
	public GameObject father1;
	public GameObject timeParticle;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		father = GameObject.FindGameObjectWithTag ("father");
		father1 = GameObject.FindGameObjectWithTag ("father1");
		count = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKeyDown (KeyCode.E)) {
			//if (count == 0) {
			StartCoroutine ("respawn");
			Instantiate (timeParticle, transform.position, transform.rotation);
			player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, 40);
			father.SetActive (false);
			father1.SetActive (true);
			camera2 = true;
			count++;
			//}
		}
	
		if (Input.GetKeyDown (KeyCode.W)) {
			//if(count==1){
			StartCoroutine ("respawn");
			player.transform.position = new Vector3 (player.transform.position.x,player.transform.position.y, -5);
			father.SetActive (true);
			father1.SetActive (false);
			camera2 = false;
			count++;
			//}
		}
		if (count == 4)
			Application.LoadLevel(2);
	}
		public IEnumerator respawn()
		{//Instantiate (timeParticle,player.transform.position, transform.rotation);
	
		yield return new WaitForSeconds (0);
		Instantiate (timeParticle,player.transform.position, transform.rotation);

	
	}

}
