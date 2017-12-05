using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ennemy : MonoBehaviour {
	public float life;
	private Animator anim;
	public int tier;
	private int aliveCounter = 0 ;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
		aliveCounter +=1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Life(float lifeToLose)
	{ 
		life = (life - lifeToLose);
		anim.SetTrigger ("IsHit");

		if (life <= 0)
		{
			aliveCounter -=1;	
			Player.score += tier * Player.multiplier;
			Destroy (gameObject);

		
		}

	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			other.GetComponent<Player> ().Death();
			Destroy (gameObject);
		}

	}

}