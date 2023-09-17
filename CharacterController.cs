<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpFor = 50f;
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    private bool grounded;
    private bool started;
    private bool jumping;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        grounded = true;
       
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (grounded && started)
            {
                animator.SetTrigger("jump");
                rigidbody2d.AddForce(new Vector2(0f, jumpFor));
                jumping = true;
                grounded = false;
            }
            else
            {
                animator.SetBool("gameStarted", true);
                started = true;
            }
        
        }
       animator.SetBool("grounded", grounded);
       grounded = true;
    }

    private void FixedUpdate()
    { 
        if(started) 
        {
            rigidbody2d.velocity = new Vector2(speed, rigidbody2d.velocity.y);
        }
        if (jumping)
        {
            rigidbody2d.AddForce(new Vector2(0f, jumpFor));
            jumping = false;
           //grounded = true;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpFor = 50f;
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    private bool grounded;
    private bool started;
    private bool jumping;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        grounded = true;
       
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (grounded && started)
            {
                animator.SetTrigger("jump");
                rigidbody2d.AddForce(new Vector2(0f, jumpFor));
                jumping = true;
                grounded = false;
            }
            else
            {
                animator.SetBool("gameStarted", true);
                started = true;
            }
        
        }
       animator.SetBool("grounded", grounded);
       grounded = true;
    }

    private void FixedUpdate()
    { 
        if(started) 
        {
            rigidbody2d.velocity = new Vector2(speed, rigidbody2d.velocity.y);
        }
        if (jumping)
        {
            rigidbody2d.AddForce(new Vector2(0f, jumpFor));
            jumping = false;
           //grounded = true;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
>>>>>>> eee12b2a48c24727a95310de0547e18a6881e202
}