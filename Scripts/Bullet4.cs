using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet4 : MonoBehaviour {
	private Rigidbody2D bull1;
	private int rebond;
	public int damage4;
	private int maxRebond;
	public GameObject bounce;
	public GameObject bounce2;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision (gameObject.layer,gameObject.layer);
		bull1 = GetComponent<Rigidbody2D> ();
		bull1.AddRelativeForce ((new Vector2(2,5)),ForceMode2D.Impulse);
		rebond = 1;
		maxRebond = 4;
	}

	// Update is called once per frame
	void Update () {

	}
	public void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Bad")
		{
			other.GetComponent<Ennemy> ().Life(damage4*Player.degats);
		}
		if (other.tag == "Player") 
		{
			other.GetComponent<Player> ().Death();
			Destroy (gameObject);
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
	}

}