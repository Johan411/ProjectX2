using UnityEngine;
using System.Collections;

public class Cam2 : MonoBehaviour {
	public float speed=2;
	public bool bounds;
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;
		if(bounds)
		{
			transform.position=new Vector3(Mathf.Clamp(transform.position.x,minCameraPos.x,maxCameraPos.x),
			                               Mathf.Clamp(transform.position.y,minCameraPos.y,maxCameraPos.y),
			                               Mathf.Clamp(transform.position.z,minCameraPos.z,maxCameraPos.z));
		}
	}
}
