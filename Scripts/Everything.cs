using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Everything : MonoBehaviour {
	public GameObject Vie; 
	public float speedy;
	public bool baleine;
	public GameObject hot;
	private float lerpage = 0.8f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Vie != null)
		{
			if (baleine == false)
			transform.position += new Vector3 (0, speedy, 0);

			if (baleine == true)
				transform.position = new Vector3 (0, hot.transform.position.y -8,0);
		}

	}
	public void Oui()
	{
		baleine = true;
	}

}
