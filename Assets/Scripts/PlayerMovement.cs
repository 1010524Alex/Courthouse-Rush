using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed;
    private Rigidbody2D rb;
    private Vector2 MovementDirection;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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

        if (MovementDirection.y > 0)
        {
            animator.SetTrigger("Exhaust");
        }

        if (MovementDirection.x>0)
        {
            gameObject.transform.localScale = new Vector3(3, 3, 1);
            gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, -15f);
            animator.SetTrigger("Exhaust");
            animator.SetTrigger("Speed Effect");
        }
        else if (MovementDirection.x<0)
        {
            gameObject.transform.localScale = new Vector3(-3, 3, 1);
            gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, 15f);
            animator.SetTrigger("Exhaust");
            animator.SetTrigger("Speed Effect");
        }
        else
        {
            gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }

        


        
            
    }

    private void FixedUpdate()
    {
        rb.velocity = MovementDirection * MovementSpeed * Time.smoothDeltaTime;
    }
}
