using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    //壁のプレハブ
    public GameObject wallPrefab;
    //タイマー
    public int timer;
    public int ran;

    void Start()
    {
        timer=0;
        ran=Random.Range(900,1200);
    }

    void Update()
    {
        timer++;
        if(timer%ran==0){
            ran=Random.Range(600,1200);
            timer=0;
            GameObject wall=GameObject.Instantiate(wallPrefab);
        }
    }
}
