using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleDirector_P : MonoBehaviour {

	//　スタートボタンを押したら実行する
    public void GameStart() {
		print("a");
            SceneManager.LoadScene ("Main_Pac Man");
	}

    //　ゲーム終了ボタンを押したら実行する
    public void GameEnd()
    {
        print("a");
        SceneManager.LoadScene("Main");
    }

    //　ゲーム終了ボタンを押したら実行する
    /*public void GameEnd() {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
		#else
		Application.Quit();
		#endif
	}

	// Use this for initialization
	void Start () {
        Screen.SetResolution(400, 710, false, 60);
	}
	
	// Update is called once per frame
	void Update () {
		
	*/

}
