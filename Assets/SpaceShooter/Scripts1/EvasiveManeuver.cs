using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvasiveManeuver : MonoBehaviour {

	public Boundary boundary; // Done_変わらない
	public float tilt;
	public float dodge;
	public float smoothing;
	public Vector2 startWait;
	public Vector2 maneuverTime;
	public Vector2 maneuverWait;
	
	private float currentSpeed;
	private float targetManeuver;
	// private Rigidbody rb;
	// public TYPE type = TYPE.PLAYER;
	// private Transform transPlayer;

	// Use this for initialization
	void Start () {
		// rb = GetComponent<Rigidbody>();
		currentSpeed = GetComponent<Rigidbody>().velocity.z; // currentSpeed = rb.velocity.z; 
		StartCoroutine(Evade());
		// transPlayer = GameObject.FindGameObjectWithTag("Player").transform;	
	}

	IEnumerator Evade() {
		yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));

		while(true) {

			targetManeuver = Random.Range (1, dodge) * -Mathf.Sign (transform.position.x);
			yield return new WaitForSeconds (Random.Range (maneuverTime.x, maneuverTime.y));
			targetManeuver = 0;
			yield return new WaitForSeconds (Random.Range (maneuverWait.x, maneuverWait.y));

			// if (type == TYPE.CENTER) {
			// 	targetManeuver = Random.Range(1, dodge) * -Mathf.Sign(transform.position.x);
			// }
			// else if (type == TYPE.PLAYER) {
			// 	targetManeuver = transPlayer.position.x;	
			// }
			// if (transPlayer != null) {
			// 	targetManeuver = transPlayer.position.x;	
			// }
			// yield return new WaitForSeconds(Random.Range(maneuverTime.x, maneuverTime.y));
			// targetManeuver = 0f;
			// yield return new WaitForSeconds(Random.Range(maneuverWait.x, maneuverWait.y));
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float newManeuver = Mathf.MoveTowards (GetComponent<Rigidbody>().velocity.x, targetManeuver, smoothing * Time.deltaTime);
		GetComponent<Rigidbody>().velocity = new Vector3 (newManeuver, 0.0f, currentSpeed);
		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);
		
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0, 0, GetComponent<Rigidbody>().velocity.x * -tilt);
		
	//  float newManeuver = Mathf.MoveTowards(rb.velocity.x, targetManeuver, Time.fixedDeltaTime * smoothing);	
	// 	rb.velocity = new Vector3(newManeuver, 0f, currentSpeed);
	// 	rb.position = new Vector3(
	// 		Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
	// 		0f,
	// 		Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
	// 	);

	// 	rb.rotation = Quaternion.Euler(0f, 0f, rb.velocity.x * -tilt);	
	// }

	// public enum TYPE {
	// 	CENTER,  //  画像中心へ
	// 	PLAYER,  //  プレイヤーを狙う
	} //;
}
