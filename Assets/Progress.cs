using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    //壁のプレハブ
    public GameObject wallPrefab;
    //タイマー
    public int timer;
    public int timer2;
    //壁と壁の間隔用変数
    public float ran;
    //加速用変数
    public float acceleration;

    void Start()
    {
        timer=0;
        timer2=0;
        //壁同士の間隔の設定
        ran=Random.Range(600,800);
        //加速の初期値
        acceleration=(float)0.01;
    }

    void Update()
    {
        timer++;
        timer2++;
        if(timer>=ran){
            //間隔の再設定
            ran=Random.Range(800,1200);
            ran/=acceleration*100;
            timer=0;
            //壁生成
            GameObject wall=GameObject.Instantiate(wallPrefab);
        }
        if(timer2%4000==0&&acceleration<=0.05){
            acceleration*=(float)1.2;
        }
    }
}
