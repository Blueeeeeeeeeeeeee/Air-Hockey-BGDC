using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderdetect : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exited");
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Staying");
        if(other.tag=="Enemy"){
            other.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
    }
}
