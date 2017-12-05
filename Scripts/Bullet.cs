using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	private Rigidbody2D bull;
	public float tir;
	public float damage;
	public GameObject bounce;
	public GameObject bounce2;
	// Use this for initialization
	void Start () 
	{
		bull = GetComponent<Rigidbody2D> ();
		bull.AddForce (new Vector2(0,tir),ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			other.GetComponent<Player> ().Death();
			Destroy (gameObject);
		}

		if (other.tag == "Bad")
		{
			other.GetComponent<Ennemy> ().Life(damage*Player.degats);
			Player.score += 5 * Player.multiplier;
		}
		Destroy (gameObject);
		GameObject clone = (GameObject)Instantiate (bounce, new Vector3 (transform.position.x,transform.position.y, 0), Quaternion.Euler (new Vector3 (0,0,135)));
		GameObject clone2 = (GameObject)Instantiate (bounce2, new Vector3 (transform.position.x,transform.position.y, 0), Quaternion.Euler (new Vector3 (0,0,45)));

	}
}
