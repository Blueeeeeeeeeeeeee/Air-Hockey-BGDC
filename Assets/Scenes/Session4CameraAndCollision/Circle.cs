using UnityEngine;



public class Session4 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 movement;
    public float speed=5f;
    public Rigidbody2D B;
    public Animator animator;

    void Update()
    {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=Input.GetAxisRaw("Vertical");

        if(Input.GetAxisRaw("Vertical")>0f||Input.GetAxisRaw("Horizontal")>0f){
            animator.SetBool("Hitted",true);
        }
        else{
            animator.SetBool("Hitted",false);
        }
        
    }

    private void FixedUpdate() {
        B.MovePosition(B.position+movement.normalized*speed);
    }
    // private void OnCollisionEnter2D(Collision2D other) {
    //     if(other.collider.tag=="Enemy"){
    //         animator.SetBool("Hitted",true);
    //     }
    // }
    // private void OnCollisionExit2D(Collision2D other) {
    //     if(other.collider.tag=="Enemy"){
    //         animator.SetBool("Hitted",false);
    //     }
    // }

}
