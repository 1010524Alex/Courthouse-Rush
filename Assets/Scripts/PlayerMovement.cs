using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed;
    private Rigidbody2D rb;
    private Vector2 MovementDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //check for an input is held

        if (Input.GetKey("left shift"))
        {
            MovementSpeed =2000f;
        }
        else
        {
            MovementSpeed =500f;
        }
        
            
    }

    private void FixedUpdate()
    {
        rb.velocity = MovementDirection * MovementSpeed * Time.smoothDeltaTime;
    }
}
