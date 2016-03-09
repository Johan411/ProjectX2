using UnityEngine;
using System.Collections;

public class Cam2 : MonoBehaviour {
	public float speed=2;
	public bool bounds;
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;

	public GameObject player;
	public LevelController level;
	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;
		if (transform.position.x > player.transform.position.x+14)
			level.reload ();
		if(bounds)
		{
			transform.position=new Vector3(Mathf.Clamp(transform.position.x,minCameraPos.x,maxCameraPos.x),
			                               Mathf.Clamp(transform.position.y,minCameraPos.y,maxCameraPos.y),
			                               Mathf.Clamp(transform.position.z,minCameraPos.z,maxCameraPos.z));
		}
	}
}
