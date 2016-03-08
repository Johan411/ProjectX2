using UnityEngine;
using System.Collections;

//bool isGrounded;

public class PlayerController : MonoBehaviour {

	const int any_to_idle = -1;

	const int idle_to_walk = 0;

	const int idle_to_jump = 2;

	const int walk_to_jump = 1;

	public float speed = 4f;

	Animator animator;

	public Vector2 jumpVector = new Vector2 (0,10);

	public int cur_state = -1;

	public bool isGrounded;

	public float init_velocity = 5f;

	public int cur_dir = 8; // 10 for right and -10 for left
	//public AudioSource audio;
	public AudioClip[] audioClip;
	public int stopSound=0;
	AudioSource audio;
	public int size;

	public GameObject[] player;
	public GameObject deathParticle;
	public float deathDelay=1.0f;
	public Vector2 initPos;
	public int currLevel;
	public LevelController level;
	// Use this for initialization
	void Start () {
		initPos = transform.position;
		player = GameObject.FindGameObjectsWithTag("Player");
		animator = this.GetComponent<Animator> ();
		audio = GetComponent<AudioSource>();
		//audio.Play();
	//	audio = this.GetComponent<AudioSource> ();

	}
	public void PlaySound(int clip)
	{
		//audio.clip = audioClip [clip];
		//audio.Play();
		audio.PlayOneShot(audioClip[1],0.35f);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Hyd") {
			Debug.Log ("dead");
			StartCoroutine("Dead1");
			}
		else if (other.tag == "enemy1") {
			Debug.Log ("dead");
			StartCoroutine("Dead1");
		
		}
		/*if (other.tag == "Finish") {
			Debug.Log ("dead");
			Application.LoadLevel (2);
		}*/
		if (other.tag == "Hyd1") {
			StartCoroutine("Dead1");
					
		}
	}

	public IEnumerator Dead1()
	{
		Instantiate (deathParticle, transform.position, transform.rotation);
		Debug.Log ("vannu");
		level.playerkill ();
		yield return new WaitForSeconds (deathDelay);
		level.reload ();
	}

	// Update is called once per frame
	void Update () {
			if (!Input.anyKey) {
		
			animator.SetInteger("state",-1);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{	//audio.Play();
				transform.position += Vector3.left * speed * Time.deltaTime;

				cur_dir = -8;

				transform.localScale = new Vector3(cur_dir, size, 1);

				animator.SetInteger("state",0);

		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
				transform.position += Vector3.right * speed * Time.deltaTime;

				cur_dir = 8;


				transform.localScale = new Vector3(cur_dir, size, 1);

				animator.SetInteger("state",0);
		}
		/*
		if (Input.GetKey(KeyCode.UpArrow) && ( Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
		{

			transform.Translate ( Vector3.up*init_velocity*Time.deltaTime );

			if ( cur_state == 0 )
			{
				//cur_state = 1;

				animator.SetInteger("state",1);

			}
			else
			{
				if ( cur_state == -1 ) 
				{
					//cur_state = 2;

					animator.SetInteger("state",2);
				}
			}
			//transform.Translate(Vector3.up*init_velocity*Time.deltaTime);
			 //GetComponent<Rigidbody2D>() .AddForce(jumpVector,ForceMode2D.Force);
		}*/

		if (Input.GetKey (KeyCode.UpArrow) && isGrounded == true) {

			transform.Translate (Vector3.up * init_velocity * Time.deltaTime);
			if (stopSound == 0) {
				PlaySound (1);
				stopSound = 1;
			}//audio.Stop ();

			//audio.Play();
			if (cur_state == 0)

				animator.SetInteger ("state", 1);
			else

				if (cur_state == -1) 

				animator.SetInteger ("state", 2);
		} else
			stopSound = 0;
	}


	void FixedUpate () {

		//Game logic and physics code goes here.

		//animator.SetInteger ("state", cur_state);



	}
}
