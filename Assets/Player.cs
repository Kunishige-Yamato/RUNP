using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.anyKeyDown){
            player.GetComponent<Rigidbody>().useGravity=true;
            Vector3 speed;
            speed.x=0;
            speed.y=8;
            speed.z=0;
            player.GetComponent<Rigidbody>().AddForce(speed,ForceMode.Impulse);
        }
    }
}
