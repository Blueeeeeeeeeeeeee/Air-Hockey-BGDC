using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quarternionLook : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector2 relativePos=target.position-transform.position;
        transform.rotation=Quaternion.LookRotation(Vector3.forward,relativePos);
        
    }
}
