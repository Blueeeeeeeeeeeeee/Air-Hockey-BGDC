using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMonoBehaviourStuffs : MonoBehaviour
{
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
    
    void FixedUpdate() {
        B.MovePosition(B.position+movement*speed);
    }
    private void LateUpdate() {
        
    }
    private void OnGUI() {
        
    }
    private void OnDisable() {
        
    }
    private void OnEnable() {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
    }
}
