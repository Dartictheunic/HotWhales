using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMDR : MonoBehaviour {
	public GameObject triggerer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Trigger")
		{
			print ("mdew");
			triggerer.GetComponent<Everything> ().Oui ();
		}
	}

}
