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
    public Animator Speed;
    
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
            BoostSpeed();
            BoostMeter.Instance.BoostUse(1);
        }
        else
        {
            RegSpeed();
        }


        if (MovementDirection.y>0)
        {
            animator.SetTrigger("Exhaust");
        }

        if (MovementDirection.x>0)
        {
            gameObject.transform.localScale = new Vector3(3, 3, 1);
            gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, -15f);
            animator.SetTrigger("Exhaust");
            Speed.SetTrigger("Speed Illusion");        
        }
        else if (MovementDirection.x<0)
        {
            gameObject.transform.localScale = new Vector3(-3, 3, 1);
            gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, 15f);
            animator.SetTrigger("Exhaust");
            Speed.SetTrigger("Speed Illusion");
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

    public void BoostSpeed()
    {
        MovementSpeed = 2000;
    }

    public void RegSpeed()
    {
        MovementSpeed = 500;
    }

}
