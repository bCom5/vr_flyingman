using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {
	public static int score = 0;
	public AudioSource source;
	public AudioClip clip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "coin") {
			
			Destroy (other.gameObject);
			source.PlayOneShot (clip);
			++score;
		}
	}

}
