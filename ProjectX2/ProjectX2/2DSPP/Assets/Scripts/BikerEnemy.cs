using UnityEngine;
using System.Collections;

public class BikerEnemy : MonoBehaviour {
	public GameObject projectile;
	public float speedFactor;
	public float Delay;
	public Vector3 e;
	// Use this for initialization
	void Start () {
		StartCoroutine (shoots());
		e = new Vector3 (-1.7f, 0.85f, -4.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator shoots()
	{
		while(true)
		{
			yield return new WaitForSeconds(Delay);
			GameObject clone= (GameObject)Instantiate(projectile,transform.position+e,Quaternion.identity);
			clone.GetComponent<Rigidbody2D>().velocity =-transform.right*speedFactor;

	}
}
}
