using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class puckhole : MonoBehaviour
{
    
    public UnityEvent onPuckEntered;


    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Entered");
        if(other.tag =="Puck"){
            Destroy(other.gameObject);
            onPuckEntered.Invoke();
        }
        
    }
}
