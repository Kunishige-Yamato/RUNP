using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //スコア用変数
    public int score;
    //テキストオブジェクトの取得
    GameObject scoreObj;
    Text scoreText;

    void Start()
    {
        score=0;
        //テキストオブジェクトの設定
        scoreObj=GameObject.Find("ScoreText");
        scoreText=scoreObj.GetComponent<Text>();
    }

    void Update()
    {
        //テキストの中身の更新
        scoreText.text=("score:"+score);
    }
}
