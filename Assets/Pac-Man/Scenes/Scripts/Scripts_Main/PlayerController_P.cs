using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement; // シーン替え


public class PlayerController_P : MonoBehaviour {

	//　タイトルボタンを押したら実行する
    public void TitleBackBottan() {
		print("a");
            SceneManager.LoadScene ("Title");
	}

	public float speed;  // 動く速さ(=20取る)
	public Text scoreText;  //  スコアのUI
	public Text winText;  //  リザルトのUI
	public Text gameOverText; // ゲームオーバーUI
	public AudioSource SoundSE;
	public AudioClip Se1;
	public AudioClip Se2;
	public AudioClip WinSE;
	public AudioClip GameOverSE;

	public GameObject retryButton;

	private bool gameClear = false; //ゲームクリアーしたら操作を無効にする
	private bool gameOver = false; //ゲームオーバーで操作を無効にする


	private bool restart;

	public Text highScoreText; //ハイスコアを表示するText
	private int highScore; //ハイスコア用変数
	private string key = "HIGH SCORE"; //ハイスコアの保存先キー
	private int score; //  スコア


    //// 2.時間経過を示す「time」変数
    //public static float time;
    //public Text ScoreTimerText;
    //public Text highScoreTimerText; //BestTimeを表示するText
    //private float highScoreTimer; //BestTime用変数
    //private string key_2 = "HIGH SCORE TIMER"; //BestTimeの保存先キー



    public void RSButtonDown() {
		if (restart) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);	
		}
	}

	// Use this for initialization
	void Start () {
		score = 0;
		gameOverText.text = "";
		scoreText.text = "Count: " + score.ToString();
		winText.text = " ";
		gameOver = false;	
		restart = false;
		retryButton.SetActive (false);
		highScore = PlayerPrefs.GetInt(key, 0);
		//保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
        highScoreText.text = "HighScore: " + highScore.ToString();
		//ハイスコアを表示
        // PlayerPrefs.DeleteAll();
		// // ハイスコアデータリセット
		// //  DontDestroyOnLoad(this);
		// // // DontDestroyOnLoadを使うことで、Sceneを切り替えてもGameObjectが破棄されなくなります。
		//AudioSourceコンポーネントを取得し、変数に格納
		SoundSE = this.gameObject.GetComponent<AudioSource>();


        //// 3.ゲーム開始時は「time」は「0」
        //time = 0;

        //highScoreTimer = PlayerPrefs.GetFloat(key_2, 0);
        ////保存しておいたBestTimeをキーで呼び出し取得し保存されていなければ0になる
        //highScoreTimerText.text = "Best Time : " + highScoreTimer.ToString();
        //// //BestTimeを表示
        //// PlayerPrefs.DeleteAll();
    }




    // Update is called once per frame
    void Update () {
		Debug.Log (score);
			GetComponent<AudioSource>().Play(); // seを鳴らす。




        //// 5.経過時間を追加
        //time = time + Time.deltaTime;

        //// 6.小数点以下を切り捨てる
        //int t = Mathf.FloorToInt(time);

        //// 7.「Text」Componentを取得して、「uiText」に格納
        //Text uiText = GetComponent<Text>();

        //// 8.テキストを編集
        //uiText.text = "Time : " + t;

        //SetCountText();


    }

	// マイキャラが他のオブジェクトにぶつかった時に呼び出される
	void OnTriggerEnter(Collider other) {
		// ぶつかったオブジェクトが収集アイテムだった場合
		if (other.gameObject.CompareTag("Item")) {
			//　その収集アイテムを非表示にします
			other.gameObject.SetActive(false);

			//  スコアを加算します
			score = score + 1;

			SoundSE.PlayOneShot(Se1);

			//  UI の表示を最新します
			SetCountText ();
		}

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

	

	void OnCollisionEnter (Collision col){
        //EnemyにぶつかるとEnemyカウント-1
        if (col.gameObject.tag == "Enemy" && score <= 0)
        {
            score = 0;
            SoundSE.PlayOneShot(Se2);
            SetCountText(); //  UI の表示を最新します
        }
        else if (col.gameObject.tag == "Enemy") {
			score -= 1;
			SoundSE.PlayOneShot(Se2);
			SetCountText (); //  UI の表示を最新します
		} 


	}

	public void AddScore(int newScoreValue) {
		score += newScoreValue;
	}

	// UI の表示を最新する
	void SetCountText() {
		//  スコアの表示を最新
		scoreText.text = "Count: " + score.ToString();
		if (!gameClear) {
			//  すべての収集アイテムを獲得した場合
			if (score >= 50) {
				//  リザルドの表示を最新
				GetComponent<MovePlayer_P>().enabled = false; // 自分のとこのコンポーネントを止める
                GetComponent<PlayerController_P>().enabled = false;//実験

                // GameObject enemy = GameObject.Find("Enemy 1"); // 止めるところの住所
                GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
				foreach (var enemy in enemys)
				{
					enemy.GetComponent<NavMeshAgent>().enabled = false; // Enemyのコンポーネントを止める。
				}
	
				winText.text = "You Win!";
				SoundSE.PlayOneShot(WinSE);
				retryButton.SetActive (true);
				restart = true;
				}

            //int t = Mathf.FloorToInt(time);

            //if (t >= 0 && t <= highScoreTimer)
            //{

            //    highScoreTimer = t;
            //    //BestTime更新

            //    PlayerPrefs.SetFloat(key, highScoreTimer);
            //    //BestTimeを保存

            //    highScoreTimerText.text = "Best Time : " + highScoreTimer.ToString();
            //    //BestTimeを表示
            //}
            //else if (t <= highScoreTimer)
            //{

            //    highScoreTimer = t;
            //    //BestTime更新

            //    PlayerPrefs.SetFloat(key, highScoreTimer);
            //    //BestTimeを保存

            //    highScoreTimerText.text = "Best Time : " + highScoreTimer.ToString();
            //    //BestTimeを表示
            //}
            //else
            //{
            //    return;
            //}



        }
		//if (gameOver) {
			if (score <= 0 || score == 0) {
				print("gameovr");
				//  リザルドの表示を最新
				GetComponent<MovePlayer_P>().enabled = false; // 自分のとこのコンポーネントを止める
                GetComponent<PlayerController_P>().enabled = false;//実験 
                                                               // GameObject enemy = GameObject.Find("Enemy 1"); // 止めるところの住所
                GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
                
				foreach (var enemy in enemys)
				{
					enemy.GetComponent<NavMeshAgent>().enabled = false; // Enemyのコンポーネントを止める。
				}
	
				gameOverText.text = "Game Over!";
				SoundSE.PlayOneShot(GameOverSE);
				print(gameOverText.text);
				retryButton.SetActive (true);
				restart = true;
			}
		//}
	}
}
