using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitchecker : MonoBehaviour
{

    public Animator animator;
    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag=="Player"||other.collider.tag=="Enemy"){
            animator.SetTrigger("triggerhit");
        }

    }
}
