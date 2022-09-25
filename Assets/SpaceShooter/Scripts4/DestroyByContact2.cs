using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DestroyByContact2 : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController_1 gameController; // Done_が抜けていた。

	void Start() {
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController"); //FindGameObjectWithTagのGameObjectが抜てた。
		if(gameControllerObject != null) {　//　gameControllerObjectの省略＝goObj(バグやエラーには無関係。)
			gameController = gameControllerObject.GetComponent<GameController_1>();　// 11行のDone_を追加により‹›もこDone_追加
		}
		if (gameController == null) {
			Debug.Log("'Game Controller'スクリプトが見つからなかった。");
		}
	}

	void OnTriggerEnter(Collider other){

		if (other.tag == "Boundary" || other.tag == "Enemy")
		{
			return;
		}
		if (explosion != null) {
			Instantiate(explosion, transform.position, transform.rotation);

		}
		
		if (other.CompareTag("Player")) {  // Compare抜いてはいけない
			// Debug.Log(this.gameObject + gameObject.transform.position.ToString()+ "に"+other+"が侵入したよ");

			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver();

		}
		Debug.Log(other.name);
		gameController.AddScore(scoreValue);
		Destroy(other.gameObject);
	    Destroy(gameObject);	
	}
}
