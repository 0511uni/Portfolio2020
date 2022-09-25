using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour {

	//　スタートボタンを押したら実行する
    public void GameStart() {
		print("a");
            SceneManager.LoadScene ("Main 1");
	}

	public void GameStart2() {
		print("b");
            SceneManager.LoadScene ("Main 2");
	}

	//　Panelボタンを押したら実行する
    public void PanelStart() {
		print("c");
            SceneManager.LoadScene ("Panel");
	}

//　ゲーム終了ボタンを押したら実行する
public void GameEnd() {
        print("z");
        SceneManager.LoadScene("Main");

        //#if UNITY_EDITOR
        //UnityEditor.EditorApplication.isPlaying = false;
        //#elif UNITY_WEBPLAYER
        //Application.OpenURL("http://www.yahoo.co.jp/");
        //#else
        //Application.Quit();
        //#endif
    }

void Start () {
        Screen.SetResolution(400, 710, false, 60);

        // int resultHitPoint = GameController.hitpoint;シーンデータ渡し
    }


    // public void StartButtonDown(){

    // }	

    // Update is called once per frame
    // void Update () {

    // 	if(Input.GetMouseButtonDown(0)){
    // 		SceneManager.LoadScene("Main");
    // 	    }				

    // }
}