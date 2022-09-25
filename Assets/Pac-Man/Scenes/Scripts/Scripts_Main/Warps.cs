using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warps : MonoBehaviour
{
　　private GameObject obj;
　　public Warps transObj;
　　private Vector3 transVec;
　　//移動状態を表すフラグ
　　public bool moveStatus;
 
　　void Start()
　　{
　　　　transVec = transObj.transform.position;
　　　　//初期では移動可能なためTrue
　　　　moveStatus = true;
　　}
 
　　void OnTriggerEnter(Collider other)
　　{
　　　　obj = GameObject.Find(other.name);
　　　　//自分が移動可能なとき移動する。
　　　　if (moveStatus)
　　　　{
　　　　　　//移動先は直後移動できないようにする
　　　　　　transObj.moveStatus = false;
　　　　　　obj.transform.position = transVec;
　　　　}
　　}
　　//物体と離れた直後呼ばれる
　　void OnTriggerExit(Collider other)
　　{
　　　　//移動可能にする。
　　　　moveStatus = true;
　　}
}