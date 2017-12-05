using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2 : MonoBehaviour {
	private Renderer rend;
	private float timer;
	private float timermax = 2f;
	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer> ();
		rend.enabled = false;
		timer = 0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		timer += Time.deltaTime;
		if (timer > timermax)
		{
			Destroy (gameObject);
		}
		if (Multiplier.moncul = true)
		{
			timer = 0;
			rend.enabled = true;
		}

	}
}
