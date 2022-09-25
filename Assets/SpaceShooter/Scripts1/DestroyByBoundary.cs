using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

	void OnTriggerExit(Collider other) {

		// if (other.CompareTag("Boundary")) {

		// 	return;
		// }OnTriggerExitでreturn;をしてはいけない。

		Destroy(other.gameObject);
        // Debug.Log(other.name);
	}
}
