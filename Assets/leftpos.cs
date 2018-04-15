using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftpos : MonoBehaviour {
	public GameObject cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Vector3 headset = OVRInput.GetLocalControllerPosition (OVRInput.Controller);
	
		Vector3 headset = OVRManager.tracker.GetPose(0).position;
		Vector3 controller = OVRInput.GetLocalControllerPosition (OVRInput.Controller.LTouch);
		Vector3 offset = headset - controller;
		Debug.Log (headset);
		Debug.Log (controller);
		Debug.Log (cam.transform.position);
		transform.position = cam.transform.position + offset;


	}
}
