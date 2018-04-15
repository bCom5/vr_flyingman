using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = "Score: " + trigger.score.ToString ();
		GetComponent<UnityEngine.UI.Text>().text = "Score: " + trigger.score.ToString ();
	}
}
