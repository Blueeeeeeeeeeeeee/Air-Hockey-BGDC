using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;



public class Session4 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 movement;
    public float speed=5f;
    public Rigidbody2D B;
    
    void Update()
    {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=Input.GetAxisRaw("Vertical");

        if(Input.GetKey("r")==true){
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject(); 
            if (bullet != null) {
                bullet.SetActive(true);
            }
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
