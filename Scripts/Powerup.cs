using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

	private bool isUsed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player" && isUsed == false)
		{
			isUsed = true;
			Player.power += 1;
			Player.degats += 1;
			Destroy (gameObject);
		}
	}
}
