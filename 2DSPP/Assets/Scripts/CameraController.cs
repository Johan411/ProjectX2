using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject Player;
	public Vector3 offset;
	private Vector2 velocity;
	//cur_x = transform.position.x;
	public float cur_x;
	public float smoothTimeY;
	public float smoothTimeX;
	public float cur_y;
	//cur_y = transform.position.y;
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;
	public bool bounds;
	public TimeTravel timeTravel;
	public float speed=2;

	// Use this for initialization
void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		//offset = transform.position - Player.transform.position;
		timeTravel = GameObject.FindObjectOfType<TimeTravel> ();
	}
	
	// Update is called once per frame
	void Update () {
	//	transform.position += Vector3.right * speed * Time.deltaTime;
		/*	cur_x = transform.position.x;

		cur_y = transform.position.y;


				
		if(Player.transform.position.x<-6)
		   ;
		   else if(Player.transform.position.x>17)
			;
		else 
			transform.position = Player.transform.position+ offset;*/
	}
 	void FixedUpdate()
		{
			float posX=Mathf.SmoothDamp(transform.position.x,Player.transform.position.x,ref velocity.x,smoothTimeX);
		float posY=Mathf.SmoothDamp(transform.position.y,Player.transform.position.y,ref velocity.y,smoothTimeY);
			transform.position=new Vector3(posX,posY,transform.position.z);
		if(bounds)
		{if(!timeTravel.camera2)
			transform.position=new Vector3(Mathf.Clamp(transform.position.x,minCameraPos.x,maxCameraPos.x),
			                               Mathf.Clamp(transform.position.y,minCameraPos.y,maxCameraPos.y),
			                               Mathf.Clamp(-10,-10,-10));
		}
		if(bounds)
		{if(timeTravel.camera2)
			transform.position=new Vector3(Mathf.Clamp(transform.position.x,minCameraPos.x,maxCameraPos.x),
			                               Mathf.Clamp(transform.position.y,minCameraPos.y,maxCameraPos.y),
			                               Mathf.Clamp(35,35,35));
		}

		}
}
