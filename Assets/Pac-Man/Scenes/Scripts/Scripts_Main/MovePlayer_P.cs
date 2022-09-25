using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer_P : MonoBehaviour {　// 長押しbutton操作で動かすスクリプト(プレイヤー)
    GameObject player;
//  動かしたいプレイヤー
    bool right = false;
//  右ボタンを押しているかの真偽値
    bool left = false;
//  左ボタンを押しているかの真偽値

    bool up = false;
//  上ボタンを押しているかの真偽値

    bool down = false;
//  下ボタンを押しているかの真偽値




    // Use this for initialization
    void Start () {
      
    }

    // Update is called once per frame
    void Update () {
        if (right) {
            goright ();
//          右に動かすためのメソッドを呼び出す
        }else if (left) {
            goleft ();
//          左に動かすためのメソッドを呼び出す
        }else if (up) {
            goup ();
//          上に動かすためのメソッドを呼び出す
        }else if (down) {
            godown ();
//          下に動かすためのメソッドを呼び出す
        } else {
//          ボタンを押していない時
            transform.rotation = Quaternion.Euler (0, 0, 0);
//          プレイヤーを元の角度に戻す
        }
         
    }

    public void RPushDown(){
//      右ボタンを押している間
        right = true;
    }

    public void RPushUp(){
//      右ボタンを押すのをやめた時
        right = false;
    }

    public void LPushDown(){
//      左ボタンを押している間
        left = true;
    }

    public void LPushUp(){
//      左ボタンを押すのをやめた時
        left = false;
    }

	
    public void UPushDown(){
//      上ボタンを押している間
        up = true;
    }

    public void UPushUp(){
//      上ボタンを押すのをやめた時
        up = false;
    }

    public void DPushDown(){
//      下ボタンを押している間
        down = true;
    }

    public void DPushUp(){
//      下ボタンを押すのをやめた時
        down = false;
    }

    public void goright(){
        if (transform.position.x <= 12.0f) {
//          プレイヤーの位置が6.0f以下の時
//          ↑画面からはみ出さないための条件
            transform.position += new Vector3 (6.0f * Time.deltaTime, 0, 0);
//          プレイヤーをx軸方向に秒速6.0fで動かす
            transform.rotation = Quaternion.Euler (0, 0, 0);
//          プレイヤーの角度をy軸周りに0度、z軸周りに(0, 0, ここ);←0度回転させる
//          ↑プレイヤーがグッと肩を入れて移動してる感を出す、この一文は無くても問題なし



        }
    }

    public void goleft(){
        if (transform.position.x >= -20.0f) {
//          プレイヤーの位置が-6.0f以上の時
//          ↑画面からはみ出さないための条件
            transform.position += new Vector3 (-6.0f * Time.deltaTime, 0, 0);
//          プレイヤーをx軸方向に秒速-6.0fで動かす
            transform.rotation = Quaternion.Euler (0, 0, 0);
//          プレイヤーの角度をy軸周りに0度、z軸周りに0度回転させる
//          ↑プレイヤーがグッと肩を入れて移動してる感を出す、この一文は無くても問題なし
        }
    }


    public void goup(){
        if (transform.position.y >= -10.0f) {
//          プレイヤーの位置が-3.0f以上の時
//          ↑画面からはみ出さないための条件
            transform.position += new Vector3 (0 * Time.deltaTime, 0, 0.5f);
//          プレイヤーをy軸方向に秒速0.5fで動かす
            transform.rotation = Quaternion.Euler (0, 0, 0);
//          プレイヤーの角度をy軸周りに0度、z軸周りに0度回転させる
//          ↑プレイヤーがグッと肩を入れて移動してる感を出す、この一文は無くても問題なし
        }
    }

    public void godown(){
        if (transform.position.y >= 0) {
//          プレイヤーの位置が3.0f以上の時
//          ↑画面からはみ出さないための条件
            transform.position += new Vector3 (0 * Time.deltaTime, 0, -0.2f);
//          プレイヤーをy軸方向に秒速-3.0fで動かす
            transform.rotation = Quaternion.Euler (0, 0, 0);
//          プレイヤーの角度をy軸周りに0度、z軸周りに0度回転させる
//          ↑プレイヤーがグッと肩を入れて移動してる感を出す、この一文は無くても問題なし
        }
    }
}   
