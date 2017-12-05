using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {

	private float initial;
	public GameObject Player1;      


	private Vector3 offset; //diff entre joueur et camera

	void Start () 
	{
		offset = transform.position - Player1.transform.position; //calcule
	}

	void LateUpdate ()
	{
		if (Player1 != null)
			transform.position = (new Vector3 (0, Player1.transform.position.y, 0) + offset); //deplace

	}

	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Bullet") 
		{
			Destroy (other.gameObject);
		}
	}
}
