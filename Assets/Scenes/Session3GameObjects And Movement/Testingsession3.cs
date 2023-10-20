using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testingsession3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Left Mouse is pressed");
        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("Right Mouse is pressed");
        }
        if(Input.GetMouseButtonDown(2)){
            Debug.Log("Middle Mouse is pressed");
        }
    }
}
