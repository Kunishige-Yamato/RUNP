using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    //壁のプレハブ
    public GameObject wallPrefab;
    //タイマー
    public int timer;
    //壁と壁の間隔用変数
    public int ran;

    void Start()
    {
        timer=0;
        //壁同士の間隔の設定
        ran=Random.Range(600,1200);
    }

    void Update()
    {
        timer++;
        if(timer%ran==0){
            //間隔の再設定
            ran=Random.Range(600,1200);
            timer=0;
            //壁生成
            GameObject wall=GameObject.Instantiate(wallPrefab);
        }
    }
}
