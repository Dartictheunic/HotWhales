using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallE : MonoBehaviour {
	public GameObject osef;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D pute)
	{
		if (pute.tag == "Bad")
		{
			GameObject.Find ("Player");
			print ("Boop"); 
			osef.GetComponent<Player> ().Death ();
		}
			

	}
}
