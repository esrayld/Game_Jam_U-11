using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController2 : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jump = 5f;
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    private bool grounded;
    private bool started;
    private bool jumping;
    private bool moving;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        grounded = true;
    }
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (rigidbody2d.velocity != Vector2.zero)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }

        rigidbody2d.velocity = new Vector2(speed, rigidbody2d.velocity.y);

        if (jumping == true)
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jump);
            jumping = false;
        }
    }
    void Update()
    {
        if (moving)
        {
            if (Input.GetKey(KeyCode.Space))
            {

                animator.SetFloat("speed", speed);

            }

        }
    }
}