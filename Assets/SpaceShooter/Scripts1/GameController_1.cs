using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Application.LoadLevel 代わり

public class GameController_1 : MonoBehaviour {

	// // クラスのメンバ変数をpublic staticで宣言しておくと、他のオブジェクトから参照ができるようになります。
	// public static int hitpoint = 0;
	

	//　タイトルボタンを押したら実行する
    public void TitleBackBottan() {
		print("a");
            SceneManager.LoadScene ("Title_SpaceShooter");
	}

	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public Text scoreText;
	public Text restartText;
	public Text bestScoreText;

	public Text gameOverText;

	public GameObject retryButton;

	private bool gameOver;
	private bool restart;
	private int score;

	public Text highScoreText; //ハイスコアを表示するText
	private int highScore; //ハイスコア用変数
	private string key = "HIGH SCORE"; //ハイスコアの保存先キー


	public void RSButtonDown() {
		if (restart) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);	
		}
	}

// 	public class Data  
// {
// 	public readonly static Data Instance = new Data();

// 	public int score = 0;
// 	public string name = string.Empty;
// }


	void Start() {
		Debug.Log(hazards.Length);
		gameOver = false;
		restart = false;
		retryButton.SetActive (false);
		// bestScore = false;
		gameOverText.text = "";
		restartText.text = "";
		// bestScoreText.text = "";
		score = 0;
		UpdateScore();
		StartCoroutine (SpawnWaves());
		highScore = PlayerPrefs.GetInt(key, 0);
		//保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
        highScoreText.text = "HighScore: " + highScore.ToString();
		//ハイスコアを表示
        // PlayerPrefs.DeleteAll();
		// // ハイスコアデータリセット
		// //  DontDestroyOnLoad(this);
		// // // DontDestroyOnLoadを使うことで、Sceneを切り替えてもGameObjectが破棄されなくなります。
		
	}

	void Update() {
				// ハイスコアより現在スコアが高い時
				if (score > highScore) {

                highScore = score;
				//ハイスコア更新

                PlayerPrefs.SetInt(key, highScore);
				//ハイスコアを保存

                highScoreText.text = "HighScore: " + highScore.ToString();
				//ハイスコアを表示
				}
        }


        // if (restart) {  // if (restart) {}を入れ忘れた。
        //     if (Input.GetKeyDown(KeyCode.R)) { //  restart && を抜き(影響なし) rsText
        //         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	
        //         // Application.LoadLevel (Application.loadedLevel);
		// 		// ↓　古い遷移を
		// 		// SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        //     }
        // }
		
//}
	IEnumerator SpawnWaves() {
		yield return new WaitForSeconds(startWait);
        Debug.Log(1);
		while(true) {
			for (int i = 0; i < hazardCount; i++) {
				GameObject hazard = hazards[Random.Range (0, hazards.Length)];
				Debug.Log(hazard.name);
				Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x,spawnValues.x), spawnValues.y, spawnValues.z);
				    Debug.Log(spawnPosition);
			    Quaternion spawnRotation = Quaternion.identity;
		        Instantiate(hazard, spawnPosition, spawnRotation);
			    yield return new WaitForSeconds(spawnWait);
		    }
			yield return new WaitForSeconds (waveWait);

			if (gameOver) {
				restartText.text = "Press 'restart Button' for Restart";
				retryButton.SetActive (true);
				// restartText.text = "Press 'R' for Restart";
				restart = true;
				// highScore = true;
				break;
			}
		}
	}

	public void AddScore(int newScoreValue) {
		score += newScoreValue;
		UpdateScore();
	}

	void UpdateScore() {
		scoreText.text = "Score: " + score;
	}

	public void GameOver() {

		gameOverText.text = "Game Over!";
		gameOver = true;
		// highscoreText.text = "Score: " + score;
	}
}