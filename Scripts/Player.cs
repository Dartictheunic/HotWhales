using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private Vector3 deplace;
	private Rigidbody2D ship;
	public float speed;
	public GameObject allyShoot;
	private float distance;
	static public int score = 0;
	public Text scoreText;
	static public int power = 1;
	static public int numberShoot = 1;
	static public int multiplier = 1;
	static public int degats = 1;
	public bool isDead = false;
	public AudioClip Tir;
	public AudioSource tg;
	private Scene okre;
	// Use this for initialization
	void Start () 
	{
		ship = GetComponent <Rigidbody2D> ();
		distance = 1f;
		tg.clip = Tir;
		tg.loop = false;
		power = 1;
		numberShoot = 1;
		multiplier = 1;
		degats = 1;
		score = 0;
		okre = SceneManager.GetActiveScene ();
	}

	// Update is called once per frame
	void Update () 
	{
		Shoot ();
		scoreText.text ="Score :" + score.ToString ();
	}

	void FixedUpdate ()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		ship.velocity = new Vector2 (horizontal * speed, vertical * speed+ 1);
		if (GameObject.FindGameObjectsWithTag("Bad").Length == 0 && okre.name == "Ludum001")
			SceneManager.LoadScene ("Credits");
	}

	public void Shoot ()
	{
		if ( Input.GetButtonDown ("Jump") == true)
		{
			tg.Play ();
			GameObject clone = (GameObject)Instantiate (allyShoot, new Vector3 (transform.position.x,transform.position.y + distance, 0), Quaternion.identity);	
		}

	}

	public void Death()
	{
		SceneManager.LoadScene ("Restart");
		Destroy (gameObject);
	}

}
