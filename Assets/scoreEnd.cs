using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = "Your Final Score is: " + trigger.score.ToString ();
		OVRInput.Update ();

		if (OVRInput.Get(OVRInput.Button.One)) {
			trigger.score = 0;
			SceneManager.LoadScene("Flight");
		}
	}
}
