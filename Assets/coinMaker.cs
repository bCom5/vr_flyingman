using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class coinMaker : MonoBehaviour {

	public Transform prefab;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 100; ++i) {
			Instantiate (prefab, new Vector3 (Random.value * 400 - 200, Random.value * 70 - 15, Random.value * 400 - 200), Quaternion.Euler(90, 0, 0));
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
