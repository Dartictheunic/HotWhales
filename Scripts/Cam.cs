using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
	
	public GameObject Player;      


	private Vector3 offset; //diff entre joueur et camera

	void Start () 
	{
		offset = transform.position - Player.transform.position; //calcule
	}

	void LateUpdate () 
	{
		if (Player != null)
			transform.position =new Vector3(0,Player.transform.position.y,0) + offset; //deplace
	}
}
