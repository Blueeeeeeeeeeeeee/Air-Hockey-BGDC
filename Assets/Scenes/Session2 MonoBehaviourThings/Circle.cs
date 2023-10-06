using UnityEngine;

public class unitymonobehaviourstuff : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 movement;
    public float speed=5f;
    public Rigidbody2D B;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        B.MovePosition(B.position+movement*speed);
    }

}
