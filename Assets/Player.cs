using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public int jump;

    void Start()
    {
        jump=0;
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
                speed.y=8;
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
}
