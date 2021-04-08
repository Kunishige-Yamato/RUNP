using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public int jump;
    //制御用オブジェクトの取得
    GameObject ControlObj;
    Progress ControlMain;

    void Start()
    {
        jump=0;
        //制御用オブジェクトの設定
        ControlObj=GameObject.Find("GameObject");
        ControlMain=ControlObj.GetComponent<Progress>();
    }

    void Update()
    {
        if(jump==0){
            //入力があったらジャンプ
            if(Input.anyKeyDown){
                jump=1;
                player.GetComponent<Rigidbody>().useGravity=true;
                Vector3 speed;
                speed.x=0;
                speed.y=12;
                speed.z=0;
                player.GetComponent<Rigidbody>().AddForce(speed,ForceMode.Impulse);
            }
        }
        if(jump==1){
            if(transform.position.y<=0.1){
                jump=0;
            }
        }  
    }

    //ぶつかったときの処理
    void OnTriggerEnter(Collider col)
    {
        string tag=col.gameObject.tag;
        //当たったのが障害物だったら
        if(tag=="Enemy"){
            ControlMain.life--;
        }
    }
}
