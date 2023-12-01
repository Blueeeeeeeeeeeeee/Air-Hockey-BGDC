using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quarternionLook : MonoBehaviour
{
    public Transform target;
    public AudioClip hitsound;
    AudioSource audio;

    // Update is called once per frame
    void Update()
    {
        Vector2 relativePos=target.position-transform.position;
        transform.rotation=Quaternion.LookRotation(Vector3.forward,relativePos);
        
    }

    void Awake() {
        audio = GetComponent<AudioSource>();
    }
    public void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player"){
            audio.clip=hitsound;
            audio.Play();
        }
    }
}
