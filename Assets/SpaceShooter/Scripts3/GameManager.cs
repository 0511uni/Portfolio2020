using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	//　タイトルボタンを押したら実行する
    public void TitleBackBottan() {
		print("a");
            SceneManager.LoadScene ("Title_SpaceShooter");
    }

	public const int WALL_FRONT = 1; // 前
	public const int WALL_RIGHT = 2; // 右
	public const int WALL_BACK = 3; // 後
	public const int WALL_LEFT = 4; // 左

	public GameObject panelwalls; // 壁全体

	public int wallNo; // 現在の向いてる方向

	// Use this for initialization
	void Start () {
		wallNo = WALL_FRONT; // スタート時点では「前」を向く	
	}
	
	// Update is called once per frame
	void Update () {

	}

	// 右(›)ボタンを押した
	public void PushButtonRight () {
		wallNo++;   // 方向を1つ右に
		// 「左」の１つ右は「前」
		if (wallNo > WALL_LEFT) {
			wallNo = WALL_FRONT;
		}
		DisplayWall (); // 壁表示最新
	}

    // 左(>)ボタンを押した
    public void PushButtonLeft () {
        wallNo--;   // 方向を一つ左に
        // 「前」の1つ右は「左」
        if (wallNo < WALL_FRONT)
        {
            wallNo = WALL_LEFT;
        }
        DisplayWall(); // 壁表示更新
    }

    // 向いている方向の壁を表示
    void DisplayWall(){
		switch (wallNo) {
			case WALL_FRONT: // 前
				panelwalls.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
				break;
			case WALL_RIGHT: // 右
				panelwalls.transform.localPosition = new Vector3 (-1000.0f, 0.0f, 0.0f);
				break;
			case WALL_BACK: // 後
				panelwalls.transform.localPosition = new Vector3 (-2000.0f, 0.0f, 0.0f);
				break;
			case WALL_LEFT: // 左
				panelwalls.transform.localPosition = new Vector3 (-3000.0f, 0.0f, 0.0f);
				break;
		}
	}

}
