using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour {
	//public GameObject end;
	public GameObject rightend;
		//rightend = GameObject.FindGameObjectWithTag ("Finish");
	public GUIText text;

	public Fader fade;
	void Start () {
		fade = FindObjectOfType<Fader> ();

	}

	void OnTriggerEnter2D(Collider2D finalEnd){
		if(finalEnd.tag == "Player"){
			Debug.Log("yoyo");
			fade.EndScene();
			//Application.LoadLevel(1);
			
		}
	}// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	
	}
}
