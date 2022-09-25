using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator2 : MonoBehaviour {

	public float tumble;
	// Rigidbody rig;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
		// rig = GetComponent<Rigidbody>();
		// rig.angularVelocity = Random.insideUnitSphere * tumble;	
	}
}
