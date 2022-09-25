using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemys : MonoBehaviour {

	public GameObject target;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		if(agent.enabled){
		agent.destination = target.transform.position;
		}
            
	}
		

	// トリガーとの接触時に呼ばれるコールバック
	void OnTriggerEnter (Collider hit)
	{
		// 接触対象はPlayerタグですか？
		if (hit.CompareTag ("Player")) {

			// 何らかの処理
		}
	}

	// private void OnCollisionEnter(Collision collision)
    // {
    //     // 物体が接触しとき、１度だけ呼ばれる
	// 	// 接触対象はPlayerタグですか？
	// 	if (collision.CompareTag ("Dor")) {

	// 		// 何らかの処理
	// 	}
    // }
}
