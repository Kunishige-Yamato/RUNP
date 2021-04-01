using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    //移動用変数
    public Vector3 pos;
    //壁の移動速度
    public float wallSpeed;

    void Start()
    {
        //壁の移動速度設定
        wallSpeed=(float)0.01;
    }

    void Update()
    {
        //壁の移動
        pos=transform.position;
        pos.z-=wallSpeed;
        transform.position=pos;
        //一定数でデフォルトの位置にリスポーン
        if(transform.position.z<-5){
            Destroy(this.gameObject);
        }
    }
}
