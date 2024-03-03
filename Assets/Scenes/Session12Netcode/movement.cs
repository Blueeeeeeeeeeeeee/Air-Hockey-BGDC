using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
public class movement : NetworkBehaviour
{

    // Update is called once per frame
    public void Update()
    {
        Vector3 move= new Vector3(0,0,0);
        if(Input.GetKey(KeyCode.W)) move.y=+1f;
        if(Input.GetKey(KeyCode.S)) move.y=-1f;
        if(Input.GetKey(KeyCode.A)) move.x=-1f;
        if(Input.GetKey(KeyCode.D)) move.x=+1f;
        
        float speed=10f;
        transform.position+=move*speed*Time.deltaTime;
        
    }

}