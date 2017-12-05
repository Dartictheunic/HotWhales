using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour {
	static public bool moncul;
	public GameObject scoreku;
	public GameObject refffe;
	public GameObject plasfh;
	// Use this for initialization
	void Start () {
		moncul = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	}

	public void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player")
		{
			Player.multiplier *= 2;
			Destroy (gameObject);
			GameObject score = Instantiate (scoreku, new Vector3 (refffe.transform.position.x,refffe.transform.position.y,0), Quaternion.identity, refffe.transform);
		}
	}

}
