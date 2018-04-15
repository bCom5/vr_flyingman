using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour {
	public float timeLeft = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0) {
			//GameOver ();
			SceneManager.LoadScene("End");
		}
		GetComponent<TextMesh>().text = "Time Left: " + ((int)timeLeft).ToString();

	}
}
