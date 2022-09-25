using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelWallManager : MonoBehaviour
{

    private Vector3 old, result;

    



    ////DataManagerの部分は、シングルトンにするクラス名を指定して下さい。
    //static public PanelWallManager instance;

    //void Awake()
    //{
    //    if (instance == null)
    //    {

    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {

    //        Destroy(gameObject);
    //    }

    //}

    ////有無のチェックフラグ
    //private static bool created = false;
    ////引き継ぎ用変数
    //public int stagedata;



    //public static int score1 = 100;//実験

    //　スタートボタンを押したら実行する
    public void GameStart_1()
    {
        print("SpaceShooter");
        SceneManager.LoadScene("Title_SpaceShooter");
    }


    //　スタートボタンを押したら実行する
    public void GameStart_2()
    {
        print("remainder_calc");
        SceneManager.LoadScene("remainder_calc");
    }

    //　スタートボタンを押したら実行する
    public void GameStart_3()
    {
        print("Pac-Man");
        SceneManager.LoadScene("Title");
    }

    public void GameStart_4()
    {
        print("Title_Jump Adventure Land");
        SceneManager.LoadScene("Title_Jump Adventure Land");
    }

  

    // 定数定義：壁方向
    public const int WALL_FRONT = 1;  // 前
    public const int WALL_RIGHT = 2;  // 右
    public const int WALL_BACK = 3;   // 後
    public const int WALL_LEFT = 4;   // 左

    public GameObject panelWalls;     // 壁全体

    private int wallNo;               // 現在向いている位置



    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(400, 710, false, 60);
        wallNo = WALL_FRONT;          // スタート時点では「前」を向く

    }

    void Update()
    {
        //result = transform.InverseTransformDirection(transform.position - old);

        //old = transform.position;
    }

    //void OnGUI() { GUI.Label(new Rect(0, 0, 200, 30), result.ToString()); }

    //　ゲーム終了ボタンを押したら実行する
    public void GameEnd()
    {
        
        SceneManager.LoadScene("Main_0");
        print("z");

    //#if UNITY_EDITOR
    //    UnityEditor.EditorApplication.isPlaying = false;
    //#elif UNITY_WEBPLAYER
    //    Application.OpenURL("http://www.yahoo.co.jp/");
    //#else
    //    Application.Quit();
    //#endif
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    // 右(>)ボタンを押した
    public void PushButtonRight()
    {
        wallNo++;   // 方向を一つ右に
        // 「左」の1つ右は「前」
        if (wallNo > WALL_LEFT)
        {
            wallNo = WALL_FRONT;
        }
        DisplayWall(); // 壁表示更新
    }

    // 左(>)ボタンを押した
    public void PushButtonLeft()
    {
        wallNo--;   // 方向を一つ左に
        // 「前」の1つ右は「左」
        if (wallNo < WALL_FRONT)
        {
            wallNo = WALL_LEFT;
        }
        DisplayWall(); // 壁表示更新

    }


    //
    void DisplayWall()
    {
        switch (wallNo)
        {
            case WALL_FRONT: //
                panelWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                break;
            case WALL_RIGHT: //
                panelWalls.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
                break;
            case WALL_BACK: //
                panelWalls.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;
            case WALL_LEFT: //
                panelWalls.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;
        }

    }

    //void Awake()
    //{

    //    if (!created)
    //    {
    //        DontDestroyOnLoad(this.gameObject);
    //        created = true;
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }

    //}
}
