using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class OVRinput : MonoBehaviour {
	public Rigidbody rb;
	public float legThrust;
	public Vector3 leftArmThrustVec;
	public Vector3 rightArmThrustVec;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		legThrust = 0;
		leftArmThrustVec = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		OVRInput.Update ();
		float leftLegThrust = OVRInput.Get (OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch);
		float rightLegThrust = OVRInput.Get (OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch);
		float leftArmThrust = OVRInput.Get (OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
		float rightArmThrust = OVRInput.Get (OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
		Quaternion rotL = OVRInput.GetLocalControllerRotation (OVRInput.Controller.LTouch);
		Vector3 leftVec = rotL * Vector3.forward;
		leftArmThrustVec = leftVec * -15f * leftArmThrust;
		Quaternion rotR = OVRInput.GetLocalControllerRotation (OVRInput.Controller.RTouch);
		Vector3 rightVec = rotR * Vector3.forward;
		rightArmThrustVec = rightVec * -15f * rightArmThrust;
		//Vector3 anglesLeftDeg = rotL.eulerAngles;
		//Vector3 anglesLeftRad = new Vector3 (anglesLeftDeg.x * (float) Math.PI / 180, anglesLeftDeg.y * (float) Math.PI / 180, anglesLeftDeg.z * (float) Math.PI / 180);
		//Vector3 multipliersLeft = new Vector3 (-1f * (float) Math.Cos (anglesLeftRad.x) * (float) Math.Cos (anglesLeftRad.y), -1f *  (float) Math.Sin (anglesLeftRad.x) * (float) Math.Cos (anglesLeftRad.y), -1f *  (float) Math.Sin (anglesLeftRad.z));
		//leftArmThrustVec = new Vector3 (10f * leftArmThrust * multipliersLeft.x, 10f * leftArmThrust * multipliersLeft.y, 10f * leftArmThrust * multipliersLeft.z);

		// rotLV =  10 * (leftArmThrust) * (rotL * Vector3.forward + rotL * Vector3.down + rotL * Vector3.left);
		//Debug.Log (rotLV);
		//Debug.Log(anglesLeftDeg);
		legThrust = - 10f * (leftLegThrust + rightLegThrust) / 2;

	}

	void FixedUpdate()
	{
		
		rb.AddForce(leftArmThrustVec.x + rightArmThrustVec.x, leftArmThrustVec.y + legThrust + rightArmThrustVec.y - 5f, 1.5f * leftArmThrustVec.z + 1.5f * rightArmThrustVec.z, ForceMode.Impulse);
	}

}
