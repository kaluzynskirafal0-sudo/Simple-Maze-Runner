using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = 10f;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (rb.isKinematic)
        {
            return;
        }
        
        float moveH = Input.GetAxisRaw("Horizontal");
        float moveV = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(moveH, 0, moveV).normalized;

        rb.linearVelocity = new Vector3(direction.x * movementSpeed, rb.linearVelocity.y, direction.z * movementSpeed);
    }
}
