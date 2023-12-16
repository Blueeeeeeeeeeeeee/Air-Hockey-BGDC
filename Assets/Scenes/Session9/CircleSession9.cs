using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSession9 : MonoBehaviour
{
    public SomeObjects CircleObj;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        Debug.Log(CircleObj.Name);
    }

}
