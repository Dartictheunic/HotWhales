using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3 : MonoBehaviour {
	private Rigidbody2D bull1;
	private int rebond;
	public int damage3;
	private int maxRebond;
	private bool bounced = false;
	public GameObject bounce;
	public GameObject bounce2;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision (gameObject.layer,gameObject.layer);
		bull1 = GetComponent<Rigidbody2D> ();
		bull1.AddRelativeForce ((new Vector2(2,5)),ForceMode2D.Impulse);
		rebond = 1;
		maxRebond = 4;
		Player.score += 1 * Player.multiplier;
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
			other.GetComponent<Ennemy> ().Life(damage3*Player.degats);
		}


	}

	public void OnCollisionEnter2D(Collision2D other)
	{
		rebond += 1;
		Player.score += 1 * Player.multiplier;
		if (rebond > maxRebond)
		{
			Destroy (gameObject);
		}
		if (rebond == maxRebond && Player.power >= 3 && bounced == false)
		{
			bounced = true;	
			Destroy (gameObject);
			GameObject clone = Instantiate (bounce, new Vector3 (transform.position.x,transform.position.y, 0), Quaternion.Euler (new Vector3 (0,0,135))) as GameObject;
			GameObject clone2 = Instantiate (bounce2, new Vector3 (transform.position.x,transform.position.y, 0), Quaternion.Euler (new Vector3 (0,0,45))) as GameObject;
		
		}
	}

}