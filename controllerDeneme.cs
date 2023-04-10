using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class controllerDeneme : MonoBehaviour
{
    [SerializeField] TMP_Text tmp1;
    [SerializeField] TMP_Text tmp;
    [SerializeField] public static bool started = false;
    [SerializeField] public static float speed =2.05f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] bool grounded = true;
    Rigidbody2D rigidbody2;
    Animator _anim;
    Scene _scene;

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
        rigidbody2 = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            started = true;
            Destroy(tmp1);
        }

        tmp.text = Coins.count.ToString();


        if (started)
        {
            _anim.SetBool("gameStarted", true);
            rigidbody2.velocity = new Vector2(speed, rigidbody2.velocity.y);
            if (Input.GetKey(KeyCode.Space) && grounded)
            {
                grounded = false;
                rigidbody2.velocity = new Vector2(rigidbody2.velocity.x, jumpForce);
                _anim.SetTrigger("jump");////////////////////////////////////////////////
            }
        }

        _anim.SetBool("grounded", grounded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("yandýrýcý"))
        {
            SceneManager.LoadScene(_scene.name);
        }
        if(collision.gameObject.CompareTag("Canavar"))
        {
            SceneManager.LoadScene(_scene.name);
        }
        
    }
















}
