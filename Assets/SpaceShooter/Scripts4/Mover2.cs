using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour {

	public float speed;
	// Rigidbody rig;　GetComponent<Rigidbody>().velocityにまとめるのでrig排除

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.forward * speed;　// rig = GetComponent<Rigidbody>(); 敵の
		// rigは使わないのでカットして、GetComponent<Rigidbody>().velocityで２つを一つにまとめる。

		// rig.velocity = rig.transform.forward * speed;　GetComponent<Rigidbody>().velocityにまとめた。

	}
	
	// Update is called once per frame
	// void Update () {
		
	// }
}
