using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

	public float init_velocity = 10;
	public float projectile_angle = 45.0f;
	public float gravity = 9.8f;
	public float speed_x;
	public float speed_y;
	public float dist_x;
	public float dist_y;
	public float elapsed_time;
	public float flight_time;
	public int flag = 0; 			// 0 for up and 1 for down

	// Use this for initialization
	void Start () {

		speed_x = init_velocity * Mathf.Cos (projectile_angle * Mathf.Deg2Rad);

		speed_y = init_velocity * Mathf.Sin (projectile_angle * Mathf.Deg2Rad);

		flight_time = Mathf.Abs(speed_y / gravity) * 2;

		elapsed_time = 0;
	
	}


	// Update is called once per frame
	void Update () {

		if (Input.anyKey) {

			if (elapsed_time >= flight_time / 2) {
			
				flag = 1;
			
				speed_y = speed_y + gravity * Time.deltaTime;
			
			} else {
			
				speed_y = speed_y - gravity * Time.deltaTime;
			}
		
			dist_x = dist_x + speed_x * Time.deltaTime;
		
			dist_y = dist_y + speed_y * Time.deltaTime;
		
			while (elapsed_time<=flight_time) {
			
				transform.Translate (dist_x, dist_y, 0);
			
			}
	
		}
	}
}
