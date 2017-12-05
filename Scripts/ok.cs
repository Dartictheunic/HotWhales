using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok : MonoBehaviour {
	new float okstv;
	new float cul;
	// Use this for initialization
	void Start () {
		okstv = 2f;
		cul = 0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		cul += Time.deltaTime;

		if (cul > okstv)
			Destroy (gameObject);
	}
}
