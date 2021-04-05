using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    //移動用変数
    public Vector3 pos;
    //壁の移動速度
    public float wallSpeed;
    //スコアオブジェクトの取得
    GameObject ScoreObj;
    Score ScoreMain;
    //制御用オブジェクトの取得
    GameObject ControlObj;
    Progress ControlMain;
    //加算用スコア変数
    public int addScore;
    //加算フラグ
    public bool addFlag;

    void Start()
    {
        //スコアオブジェクトの設定
        ScoreObj=GameObject.Find("Score");
        ScoreMain=ScoreObj.GetComponent<Score>();
        //制御用オブジェクトの設定
        ControlObj=GameObject.Find("GameObject");
        ControlMain=ControlObj.GetComponent<Progress>();
        //加算スコア設定
        addScore=10;
        //フラグ初期設定
        addFlag=false;
        //壁の移動速度設定
        wallSpeed=(float)ControlMain.acceleration;
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
        //Playerの後ろまで到達したら点数加算
        if(transform.position.z<-1&&addFlag==false){
            ScoreMain.score+=addScore;
            addFlag=true;
        }
    }
}
