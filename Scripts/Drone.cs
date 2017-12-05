using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour {

	public GameObject joueur;
	private float xoffset;
	private float distance = 0.5f;
	public GameObject shootduku;
	// Use this for initialization
	void Start () {
		joueur = GameObject.Find ("Player");
		xoffset = transform.position.x - joueur.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position =new Vector3(joueur.transform.position.x + xoffset, joueur.transform.position.y,0);
		Shoot2 ();
	}
	public void Shoot2 ()
	{
		if ( Input.GetButtonDown ("Jump") == true)
		{
			GameObject clone = (GameObject)Instantiate (shootduku, new Vector3 (transform.position.x,transform.position.y + distance, 0), Quaternion.identity);	
		}

	}


}
