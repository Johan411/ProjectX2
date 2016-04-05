using UnityEngine;
using System.Collections;
public class CameraZoom : MonoBehaviour {

	// Use this for initialization
	public Camera main;
	public Camera zoom;
	public GameObject playerscript;
	//public GameObject cameraz;
	//public Animation animation123;
	//public Animator animator
	//public Animation animation;
	void Start () {

		main.enabled = false;
		zoom.enabled = true;
		playerscript = GameObject.Find ("Player");
		playerscript.GetComponent<PlayerController> ().enabled = false;
		//this.GetComponent<Animation> ().Play ();
		//cameraz = this.gameObject;
		//cameraz.GetComponent<Animation> ().Play ();
		//animation123.Play ();
	}
	
	// Update is called once per frame
	void Update () {
			
		//yield WaitForSeconds(5);
		if (Input.GetKey(KeyCode.Return)) {
			
			main.enabled = true;
			zoom.enabled = false;
			//playerscript = GameObject.Find ("Player");
			playerscript.GetComponent<PlayerController> ().enabled = true;
		}

		//cameraz.GetComponent<Animation> ().Play ();
		/*if (Input.GetKey (KeyCode.A)) {

			main.enabled = true;
			zoom.enabled = false;
			//playerscript = GameObject.Find ("Player");
			playerscript.GetComponent<PlayerController> ().enabled = true;

		}
*/	
	}
}
