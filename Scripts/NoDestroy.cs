using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestroy : MonoBehaviour {
	public AudioClip son;
	public AudioSource source;
	// Use this for initialization
	void Start () {
		source.clip = son;
		source.playOnAwake = false;
		if (source.isPlaying == false)
			source.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (gameObject);

	}


}
