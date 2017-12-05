using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DronePowerUp : MonoBehaviour {
	private int shots = 1;

	public GameObject Drone;
	public GameObject Joueur;
	private bool hasTake = false;
	private float nikk = 0.4f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player" && Player.numberShoot == 1 && hasTake == false)
		{
			hasTake = true;
			Player.numberShoot += 1;
			GameObject clone = (GameObject)Instantiate (Drone,new Vector3 (Joueur.transform.position.x +nikk,Joueur.transform.position.y, 0), Quaternion.identity);
			Destroy (gameObject);
		}
		if (other.tag == "Player" && Player.numberShoot == 2 && hasTake == false)
		{
			Player.numberShoot += 1;
			GameObject clone = (GameObject)Instantiate (Drone,new Vector3 (Joueur.transform.position.x -nikk,Joueur.transform.position.y, 0), Quaternion.identity);
			Destroy (gameObject);
		}
	}
}
