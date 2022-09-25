using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AudioSource;

[System.Serializable]
public class Boundary {
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController_1 : MonoBehaviour {

    // Rigidbody rig = null;
	public float speed;
	public float tilt;
	public Boundary boundary;

	public GameObject shot;
	public Transform shotSpawn; //public Transform [] shotSpawn; []をとってみた。public Transform shotSpawn;
	public float fireRate;
	private float nextFire;  //float nextFire;
	//  AudioSource myAudio;
    // MovePlayerのEvent Triggerに変更。これはOnClick用だった。
	
	// public void LButtonDown() {
	// 	transform.Translate(-3, 0, 0);
	// }

	// public void RButtonDown() {
	// 	transform.Translate(3, 0, 0);
	// }

	// public void UButtonDown() {
	// 	transform.Translate(0, 0, 3);
	// }

	// public void DButtonDown() {
	// 	transform.Translate(0, 0, -3);
	// }

	// ショットはOnClickのまま。こちらを継続利用。
	public void SButtonDown() {
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		GetComponent<AudioSource>().Play ();
	}


//}
	void Update() {


		// if (Input.GetButton("Fire1") && (Time.time > nextFire)) { // マウス

		//  nextFire = Time.time + fireRate;
		// 	Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		// 	GetComponent<AudioSource>().Play ();

			foreach(Transform shotSpawn in shotSpawn) {
				Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			}
			// myAudio.Play();
		//}
		
	}

	// // // Use this for initialization
	// void Start () {
	// 	// rig = GetComponent<Rigidbody>();
	// 	myAudio = GetComponent<AudioSource>();			
	
	// Update is called once per frame
	void FixedUpdate () {
		// float moveHorizontal = Input.GetAxis("Horizontal"); // 
		// float moveVertical = Input.GetAxis("Vertical");
        
		// Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);  // Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);  moveHorizontal, 
       
        // GetComponent<Rigidbody>().velocity = movement * speed;
		
		// プレーヤーのポジション設定。
		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);
		
		// GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt); // くるって回るやつ


		// rig.velocity = movement;
		// rig.velocity = movement * speed;
		// rig.position = new Vector3(
		// 	Mathf.Clamp(rig.position.x, boundary.xMin, boundary.xMax),
		// 	0f,
		// 	Mathf.Clamp(rig.position.z, boundary.zMin, boundary.zMax)
		// );
		// rig.rotation = Quaternion.Euler(0f, 0f, rig.velocity.x * -tilt);	
	}
}
