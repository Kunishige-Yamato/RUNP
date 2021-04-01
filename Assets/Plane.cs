using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    //地面のリスポーン座標
    public Vector3 defPos;
    //移動用変数
    public Vector3 pos;

    void Start()
    {
        //リスポーン位置の指定
        defPos.x=0;
        defPos.y=-1;
        defPos.z=25;
    }

    void Update()
    {
        //地面の移動
        pos=transform.position;
        pos.z-=(float)0.01;
        transform.position=pos;
        //一定数でデフォルトの位置にリスポーン
        if(transform.position.z<-15){
            transform.position=defPos;
        }
    }
}
