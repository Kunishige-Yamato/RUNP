using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    //ライフ用変数
    public int life;
    public int lifeDef;
    public int lifeDif;
    public int lifeSave;
    //キャンバスの取得
    public GameObject canvas;
    //ハートのプレハブ
    public GameObject heartPrefab;
    //ハート表示位置調整用変数
    public Vector3 heartPos;

    void Start()
    {
        timer=0;
        timer2=0;
        //壁同士の間隔の設定
        ran=Random.Range(600,800);
        //加速の初期値
        acceleration=(float)0.01;
        //ライフ残量設定
        lifeDef=3;
        life=lifeDef;
        lifeSave=0;
        //キャンバスの設定
		var canvas=GameObject.Find("Canvas");
        //ハート位置の設定
        heartPos.x=50;
        heartPos.y=910;
        heartPos.z=0;
        //ハート生成
        for(int i=0;i<lifeDef;i++){
            GameObject heart=GameObject.Instantiate(heartPrefab);
            heart.transform.SetParent(canvas.transform,false);
            heart.transform.position=heartPos;
            heart.name="heart"+(lifeDef-i);
            heartPos.x+=60;
        }
    }

    void Update()
    {
        timer++;
        timer2++;
        //壁の複数生成用
        if(timer>=ran){
            //間隔の再設定
            ran=Random.Range(800,1200);
            ran/=acceleration*100;
            timer=0;
            //壁生成
            GameObject wall=GameObject.Instantiate(wallPrefab);
        }
        //加速
        if(timer2%4000==0&&acceleration<=0.04){
            acceleration*=(float)1.2;
        }
        //ライフ管理
        if(life<lifeDef){
            //ライフの変化の感知
            lifeDif=lifeDef-life;
            if(lifeDif!=lifeSave){
                lifeSave=lifeDif;
                GameObject heartDel=GameObject.Find("heart"+lifeDif);
                Destroy(heartDel.gameObject);
            }
        }
        //ゲームオーバー
        if(life<=0){
            SceneManager.LoadScene("Result");
        }
    }
}
