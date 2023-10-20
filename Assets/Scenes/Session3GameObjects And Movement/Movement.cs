using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //In unity there's Vector2.x and Vector2.y (and z if you are using Vector3)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        PositionMove();
        
        MouseLooker();
        
    }

    private void MouseLooker()
    {
        Vector2 mousePs = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePs - new Vector2(transform.position.x, transform.position.y);
        
    }

    void PositionMove()
    {
        if(Input.GetKey("left shift")){
            rb.MovePosition(rb.position + movement.normalized *2* moveSpeed * Time.fixedDeltaTime);
        }
        else{
            rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
        }
        
    }
}
