using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet2 : MonoBehaviour {
	private Rigidbody2D bull1;
	private int rebond;
	public int damage2;
	private int maxRebond;
	public GameObject bounce;
	public GameObject bounce2;
	private bool bounced;
	// Use this for initialization
	void Start () {
		bounced = false;
		Physics2D.IgnoreLayerCollision (gameObject.layer,gameObject.layer);
		bull1 = GetComponent<Rigidbody2D> ();
		bull1.AddRelativeForce ((new Vector2(2,5)),ForceMode2D.Impulse);
		rebond = 1;
		maxRebond = 3;
		Player.score += 2 * Player.multiplier;
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
			other.GetComponent<Ennemy> ().Life(damage2*Player.degats);
		}


	}

	public void OnCollisionEnter2D(Collision2D other)
	{
		rebond += 1;
		Player.score += 2 * Player.multiplier;
		if (rebond == maxRebond && Player.power >= 2 && bounced == false)
		{
			bounced = true;
			Destroy (gameObject);
			GameObject clone = Instantiate (bounce, new Vector3 (transform.position.x,transform.position.y, 0), Quaternion.Euler (new Vector3 (0,0,135))) as GameObject;
			GameObject clone2 = Instantiate (bounce2, new Vector3 (transform.position.x,transform.position.y, 0), Quaternion.Euler (new Vector3 (0,0,45))) as GameObject;

		}
		if (rebond > maxRebond)
		{
			Destroy (gameObject);
		}
	}

}
