using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    float speed = 5.0f;
    public static int keys = 0;
    public Text keyNum;
    Vector2 input;
    Animator animator;
    Vector2 targetPos;
    bool isMoving;
    [SerializeField] GameObject text;



    void Start()
    {
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);
            Destroy(text);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            Destroy(text);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,speed * Time.deltaTime, 0);
            Destroy(text);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            Destroy(text);
        }


        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        targetPos = transform.position;
        targetPos.x += input.x;
        targetPos.y += input.y;


        if (input != Vector2.zero)
        {
            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
        }
        Vector2 a = transform.position;

        if (targetPos != a)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        animator.SetBool("isMoving", isMoving);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "walls")
        {

        }
        if (collision.gameObject.tag == "Keys")
        {
            keys++;
            keyNum.text = "Keys Collected: " + keys;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            keys = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "Chest" )
        {
            //buraya sahne geçiþi koy
        }
    }
    
}
