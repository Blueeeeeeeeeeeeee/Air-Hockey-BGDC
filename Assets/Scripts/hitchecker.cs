using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitchecker : MonoBehaviour
{

    public Animator animator;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag!="Puck"){
            animator.SetBool("Hitted",true);
        }
            


    }

    void OnCollisionExit2D(Collision2D other)
    {
        if(other.collider.tag!="Puck"){
            animator.SetBool("Hitted",false);
        }
            
    }
}
