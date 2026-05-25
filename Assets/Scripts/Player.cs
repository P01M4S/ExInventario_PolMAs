using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    private float movementSpeed = 5;


    void Awake()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
       
    }
    void FixedUpdate()
    {
        rbody2D.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rbody2D.linearVelocity.y);
    }
}



